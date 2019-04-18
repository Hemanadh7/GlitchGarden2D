using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	//public Variables.
	public GameObject projectile,Gun,myObject;


	//private Variables.
	private AudioSource shotAudio;
	private Spawner myLaneSpawner;
	private Spawner[] Spawners;
	private GameObject projectileParent;
	private Animator animator;

	// Use this for initialization
	void Start () {
		shotAudio = GetComponent<AudioSource>();
		Spawners = GameObject.FindObjectsOfType<Spawner>();
		animator = GetComponent<Animator>();

		//Find the projectileParent GameObject otherwise creating one.
		projectileParent = GameObject.Find("Projectiles");
		if(!projectileParent)
		{
			projectileParent = new GameObject("Projectiles");
		}

		SetMyLaneSpawner();
		print (myLaneSpawner);
	}

	// Update is called once per frame
	void Update () {

		if(IsAttackerAheadInLane())
		{
			animator.SetBool("IsAttacking",true);
		}else {
			animator.SetBool("IsAttacking",false);
		}
	
	}

	void SetMyLaneSpawner()
	{
		//Capturing the targetSpawner(Target) in myLaneSpawner.
		foreach(Spawner targetSpawner in Spawners)
		{
			Vector3 targetSpawnerPos = targetSpawner.transform.position;
			if(targetSpawnerPos.y == transform.position.y )
			{
				myLaneSpawner = targetSpawner;
				return;//Interrupting the loop execution.
			}
		}
		Debug.LogError("No Spawner found");
	}

	bool IsAttackerAheadInLane()
	{
		//Toggling the IsAttackerAheadMethod.
		if(myLaneSpawner.transform.childCount > 0){
			return true;
		}
		foreach(Transform attacker in myLaneSpawner.transform){
			if(attacker.transform.position.x > transform.position.x){
				return true;
			}
		}

		//Attacker in Lane, but behind us.
		return false;
	}

	private void Fire()
	{
		//Making the Projectile fire from projectileParent.
		GameObject newProjectile = Instantiate(projectile,Gun.transform.position,Gun.transform.rotation) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		shotAudio.Play();
		shotAudio.volume = PlayerPrefsManager.GetMasterVolume();
	}
}
