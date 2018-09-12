using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void changeScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

	public void nextScene() {
	    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	    SceneManager.LoadScene(currentSceneIndex + 1);
	}

	public void quitGame() {
	    print("Quit Game!");
	}
}
