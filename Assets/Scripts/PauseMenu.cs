using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	//private Button[] button;
	public GameObject coreGame;
	public GameObject exitMenu;

	public static string Level_key = "level";

	void start()
	{
		//button = GameObject.FindObjectsOfType<Button>();
		gameObject.SetActive(false);
	}

	public void SaveGame()
	{
		PlayerPrefs.SetInt(Level_key,Application.loadedLevel);
		print ("Saved Level: " + Application.loadedLevel);
	}

	public void LoadPauseMenu()
	{
		gameObject.SetActive(true);
		Time.timeScale = 0f;
		coreGame.SetActive(false);
	}

	public void ResumeButton()
	{
		gameObject.SetActive(false);
		Time.timeScale = 1f;
		coreGame.SetActive(true);
		exitMenu.SetActive(false);
	}
	public void ExitMenu()
	{
		exitMenu.SetActive(true);
		Time.timeScale = 0f;
		coreGame.SetActive(false);
	}
}
