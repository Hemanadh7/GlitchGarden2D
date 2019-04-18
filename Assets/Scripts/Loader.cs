using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	public void LoadGame()
	{
		Application.LoadLevel(PlayerPrefsManager.GetSavedLevel());
	}
}
