using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	private Image splashImage;
	private LevelManager lm;

	#region Custom Methods
	void closeSplashScene() {
		lm.changeScene(1);
	}

	void getComponentsFindObjects() {
		splashImage = GetComponent<Image>();
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}

	void invokeMethods() {
		Invoke("makeOpaque", 1.5f);
		Invoke("closeSplashScene", 3.5f);
	}

	void makeOpaque() {
		splashImage.color = new Color(1f, 1f, 1f, 1f);
	}
	#endregion

	// Use this for initialization
	void Start () {
		getComponentsFindObjects();
		invokeMethods();
	}
}
