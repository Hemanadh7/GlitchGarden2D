using UnityEngine;
using System.Collections;

public class GameLoader : MonoBehaviour {

	public void LoadGame()
	{
		Application.LoadLevel(PlayerPrefs.GetInt(PauseMenu.Level_key));
		print ("Loaded");
	}

	public void ResetGame()
	{
		PlayerPrefs.DeleteKey(PauseMenu.Level_key);
	}
}
