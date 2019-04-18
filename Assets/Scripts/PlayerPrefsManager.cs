using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	
	const string MASTER_VOLUME_KEY = "master_volume";
	const string LEVEL_DIFFICULTY_KEY = "level_difficulty";
	const string LEVEL_UNLOCK_KEY = "level_unlock_";
	//const string SAVES_Key = "save_key";

	public static int GetSavedLevel()
	{
		return PlayerPrefs.GetInt("save_level");
	}

	public static void SetMasterVolume(float volume)
	{
		if(volume > 0f && volume <= 1f)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY,volume);
		}else
		{
			Debug.LogError("Master volume exists beyond limit");
		}
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}


	public static void UnlockLevel(int level)
	{
		if(level < Application.levelCount -1 )
		{
			PlayerPrefs.SetInt(LEVEL_UNLOCK_KEY + level.ToString() ,1);
		}else
		{
			Debug.LogError("level not existed");
		}
	}

	public static bool IsLevelUnlocked(int level)
	{
		int levelvalue = PlayerPrefs.GetInt(LEVEL_UNLOCK_KEY + level.ToString());
		bool isLevelunlocked = (levelvalue == 1);
		if(level < Application.levelCount -1 )
		{
			return isLevelunlocked;
		}else
		{
			Debug.LogError("level not existed");
			return false;
		}
	}

	public static void SetDifficulty(float Difficulty)
	{
		if(Difficulty >= 1f && Difficulty <= 3f)
		{
			PlayerPrefs.SetFloat(LEVEL_DIFFICULTY_KEY,Difficulty);
		}else
		{
			Debug.LogError("Difficulty not existed");
		}
	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(LEVEL_DIFFICULTY_KEY);
	}

}
