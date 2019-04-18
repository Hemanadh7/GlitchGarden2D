using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] attackerPrefabArray;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject thisattacker in attackerPrefabArray)
		{
			if(IsTimeToSpan(thisattacker))
			{
				Spawn(thisattacker);
			}
		}
	
	}

	void Spawn(GameObject myGameobject)
	{
		GameObject myAttacker = Instantiate (myGameobject) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	}

	bool IsTimeToSpan(GameObject attackerGameobject)
	{
		Attacker attacker = attackerGameobject.GetComponent<Attacker>();
		float newSpawnTime = attacker.seenEverySeconds;

		float meanspawnDelay = newSpawnTime;
		float spawnsPerSecond = 1/meanspawnDelay;

		if(Time.deltaTime > meanspawnDelay)
		{
			Debug.LogWarning("Frame rate capped");
		}

		float threshold = spawnsPerSecond*Time.deltaTime/5;

		if(Random.value < threshold)
		{
			return true;
		}else{
			return false;
		}

		//return true;
	}

}
