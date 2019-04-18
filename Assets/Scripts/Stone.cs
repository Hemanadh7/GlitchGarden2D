using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if(col.tag == "Attackers")
		{
			anim.SetTrigger("IsAttackingTrigger");
		}
	}
}
