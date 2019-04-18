using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionController : MonoBehaviour {
	
	public LevelManager levelManager;

	public Slider volumeSlider;
	public Slider difficultySlider;
	public static float value;

	private MusicManager musicManager;

	// Use this for initialization
	void Start () 
	{
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () 
	{
		musicManager.ChangeVolume(volumeSlider.value);
		Debug.Log(difficultySlider.value);
		value = difficultySlider.value;
	}

	public void SaveAndExit()
	{
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		levelManager.LoadLevel("Start Menu");
	}

	public void SetDefaults()
	{
		volumeSlider.value =0.8f;
		difficultySlider.value = 2.0f;
	}
}
