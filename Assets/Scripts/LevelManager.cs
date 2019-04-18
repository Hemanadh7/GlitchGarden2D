using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float loadStartSceneafter; 

	void Start()
	{
		if(loadStartSceneafter != 0)
		{
		
			Invoke("LoadNextLevel",loadStartSceneafter);
		}
	}
	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
		//int level = Application.loadedLevel + 2;
		//PlayerPrefsManager.SetCurrentSavedLevel(level);
		//print (level);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel+1);
	}

}
