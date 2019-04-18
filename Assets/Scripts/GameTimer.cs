using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	public float levelSeconds;
	public Slider slider;

	private AudioSource audioSource;
	private bool isLevelEnded = false;
	private LevelManager levelManager;
	private GameObject winState;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		winState = GameObject.Find("You Win");
		winState.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad/levelSeconds;
		if(slider.value == 1f && !isLevelEnded)
		{
			audioSource.volume = PlayerPrefsManager.GetMasterVolume();
			audioSource.Play();
			Invoke("LoadNextLevel",audioSource.clip.length);
			winState.SetActive(true);
			isLevelEnded = true;
		}
	}

	void LoadNextLevel()
	{
		levelManager.LoadNextLevel();
	}
}
