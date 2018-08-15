using UnityEngine;
using System.Collections;

public class winLoseMock : MonoBehaviour {
	private LevelManager lm;

	void getComponentsFindObjects() {
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}

	void Start () {
	    getComponentsFindObjects();
	}

	void OnGUI () {
	    if (GUI.Button(new Rect(10, 10, 50, 20), "Win")) {
	        lm.changeScene("3a_WinScene");
	    }
	    else if (GUI.Button(new Rect(10, 40, 50, 20), "Lose")) {
	        lm.changeScene("3b_LoseScene");
	    }
	}
}
