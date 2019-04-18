using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Attacker))]
public class Lizard : MonoBehaviour {

	private Attacker attacker;
	private Animator anim;
	GameObject obj;

	// Use this for initialization
	void Start () 
	{
		attacker = GetComponent<Attacker>();
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		obj = col.gameObject;
		if(col.tag == "Defenders" || col.tag == "Stone")
		{
			anim.SetBool("isAttacking",true);
			attacker.Attack(obj);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
