using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void changeScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

	public void quitGame() {
	    print("Quit Game!");
	}
}
