using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Attackers")
		{
			Application.LoadLevel("Lose Screen");
			//Application.LoadLevel(PlayerPrefsManager.GetSavedLevel());
			//Application.LoadLevel(LevelManager.LoadLevel());
		}
	}
}
