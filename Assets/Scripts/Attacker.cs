using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	public float seenEverySeconds;

	private float currentSpeed;
	private GameObject currentTarget;
	private Animator anim;

	// Use this for initialization
	void Start () 
	{
		if(PlayerPrefsManager.GetDifficulty() == 1f)
		{
			seenEverySeconds = seenEverySeconds*2;
			print(seenEverySeconds);
		}
		
		if(PlayerPrefsManager.GetDifficulty() == 3f)
		{
			seenEverySeconds = seenEverySeconds/2;
			print(seenEverySeconds);
		}

		anim = GetComponent<Animator>();
	}

	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.left*currentSpeed*Time.deltaTime);
		if(!currentTarget)
		{
			anim.SetBool("isAttacking",false);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log(transform.name + "Triggered");
	}

	public void SetSpeed(float speed)
	{
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage)
	{

		Debug.Log("Damage done: "+ damage);
		if(currentTarget)
		{
			Health health = currentTarget.GetComponent<Health>();
			if(health)
			{
				health.DealDamage(damage);
			}
		}
	}

	public void Attack(GameObject obj)
	{
		currentTarget = obj;
	}
}
