using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] musicIndexarray;
	private AudioSource audioSource;

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	public void ChangeVolume(float value)
	{
		audioSource.volume = value;
	}

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void OnLevelWasLoaded (int level) 
	{
		AudioClip thisMusic = musicIndexarray[level];
		if(thisMusic)
		{
			audioSource.clip = thisMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
