using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	private Image splashImage;
	private LevelManager lm;
	private Text subtitle;

	#region Custom Methods
	void closeSplashScene() {
		lm.changeScene("StartMenu");
	}

	void getComponentsFindObjects() {
		splashImage = GetComponent<Image>();
		subtitle = transform.Find("Subtitle").GetComponent<Text>();
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}

	void invokeMethods() {
		Invoke("setSplashActive", 1.5f);
		Invoke("closeSplashScene", 3.5f);
	}

	void makeOpaque() {
		splashImage.color = new Color(1f, 1f, 1f, 1f);
	}

	void setSplashActive() {
		splashImage.enabled = true;
		subtitle.enabled = true;
	}
	#endregion

	// Use this for initialization
	void Start () {
		getComponentsFindObjects();
		invokeMethods();
	}
}
