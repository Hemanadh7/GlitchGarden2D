using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private AudioSource damageSound;

	public float Speed,Damage;
	GameObject Obj;

	// Use this for initialization
	void Start () {
		damageSound = GetComponent<AudioSource>();
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		Obj = col.gameObject;
		if(Obj)
		{
			if(Obj.tag == "Attackers")
			{
				damageSound.Play();
				Health health = Obj.GetComponent<Health>();
				if(health)
				{
					health.DealDamage(Damage);
					Destroy(gameObject);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.right*Speed*Time.deltaTime);
	
	}
}
