using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	const string MASTER_VOLUME = "master_volume";
	const string DIFFICULTY = "difficulty";
	const string UNLOCK_LEVEL = "unlock_level_";

	#region Getters
	public static int GetDifficulty () {
		return PlayerPrefs.GetInt(DIFFICULTY);
	}

	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat(MASTER_VOLUME);
	}

	public static bool GetUnlockLevel (int level) {
		return PlayerPrefs.GetInt(UNLOCK_LEVEL + level) == 1;
	}
	#endregion

	#region Setters
	public static void SetDifficulty (int difficulty) {
		if (difficulty >= 1 && difficulty <= 3) {
			PlayerPrefs.SetInt(DIFFICULTY, difficulty);
		} else {
			Debug.LogError("Difficulty level out of range");
		}
	}

	public static void SetMasterVolume (float volume) {
		if (volume > 0f && volume < 1f) {
			PlayerPrefs.SetFloat(MASTER_VOLUME, volume);
		} else {
			Debug.LogError("Master volume out of range");
		}
	}

	public static void SetUnlockLevel (int level) {
		if (level >= 0 && level < SceneManager.sceneCountInBuildSettings - 1) {
			PlayerPrefs.SetInt(UNLOCK_LEVEL + level, 1);
		} else {
			Debug.LogError("Unlocking level out of range");
		}
	}
	#endregion
}
