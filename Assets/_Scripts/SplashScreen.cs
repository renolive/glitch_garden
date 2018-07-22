using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	private Image splashImage;
	private LevelManager lm;
	private Text subtitle;
	private float timerFade = 0;

	public float fadeTime;

	#region Custom Methods
	void closeSplashScene() {
		lm.changeScene("1a_StartMenu");
	}

	/**
	 * Fade in splash image
	 */
	void fadeIn() {
	    if (timerFade <= fadeTime) {
			timerFade += Time.deltaTime;
			float alpha = (timerFade / fadeTime);
			splashImage.color = new Color(1f, 1f, 1f, Mathf.Min(alpha, 1f));  // limits max alpha value to 1.0f
	    }
	}

	void getComponentsFindObjects() {
		splashImage = GetComponent<Image>();
		subtitle = transform.Find("Subtitle").GetComponent<Text>();
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}

	void invokeMethods() {
		Invoke("setSplashTextActive", 1.5f);
		Invoke("closeSplashScene", 3.5f);
	}

		void setSplashTextActive() {
		subtitle.enabled = true;
	}
	#endregion

	// Use this for initialization
	void Start () {
		getComponentsFindObjects();
		invokeMethods();
	}

	void Update() {
	    fadeIn();
	}
}
