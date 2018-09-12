using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class LevelTimer : MonoBehaviour {
	private Slider slider;
	private LevelManager lm;

	public float TotalTime;
	public AudioClip FinishLevelAudio;

	#region CustomMethods
	void GetComponentsAndObjects ()
	{
		slider = GetComponent<Slider>();
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}

	IEnumerator UpdateTimer() {
		while(true) {
			slider.value = Time.timeSinceLevelLoad/TotalTime;
			if (slider.value >= 1) {
				TimerFinished();
				break;
			}
			yield return null;
		}
	}

	void NextLevel() {
		lm.nextScene();
	}

	void TimerFinished () {
		print ("sdfjdlfjsdf");
		AudioSource.PlayClipAtPoint(FinishLevelAudio, transform.position);
		Invoke("NextLevel", 1);
	}
	#endregion

	void Start () {
		GetComponentsAndObjects();
		StartCoroutine("UpdateTimer");
	}
	
	void Update () {
//		UpdateTimer();
	}
}
