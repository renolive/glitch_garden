using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void changeScene(int sceneIndex) {
		SceneManager.LoadScene(sceneIndex);
	}
}
