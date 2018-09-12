using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelTimer : MonoBehaviour {
	private Slider slider;
	private LevelManager lm;
	private float elapsedTime=0 ;

	public float TotalTime;

	#region CustomMethods
	void GetComponentsAndObjects ()
	{
		slider = GetComponent<Slider>();
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}

	void UpdateTimer () {
	    elapsedTime += Time.deltaTime;
	    slider.value = elapsedTime/TotalTime;

	    if (slider.value >= 1) {
	        TimerFinished();
	    }
	}

	void TimerFinished () {
	    lm.nextScene();
	}
	#endregion

	void Start () {
		GetComponentsAndObjects();
	}
	
	void Update () {
		UpdateTimer();
	}
}
