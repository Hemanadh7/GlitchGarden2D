using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn(GameObject myGameObject)
	{
		Instantiate(myGameObject,transform.position,transform.rotation);
	}
}
