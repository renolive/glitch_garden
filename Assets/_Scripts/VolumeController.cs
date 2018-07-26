using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VolumeController : MonoBehaviour {
	Slider slider;
	AudioSource musicPlayer;

	public float DefaultValue;

	#region Custom Methods
	void addEventsListeners () {
		slider.onValueChanged.AddListener(delegate {setVolume(slider.value);});
	}

	void getComponentsFindObjects () {
		slider = transform.Find("Slider").GetComponent<Slider>();
		musicPlayer = GameObject.Find("Music Player").GetComponent<AudioSource>();
	}

	public void SaveVolume () {
		PlayerPrefsManager.SetMasterVolume(slider.value);
	}

	public void SetDefaultVolume () {
		setVolume(DefaultValue);
	}

	void setVolume (float value) {
		if (value >= 0f && value <= 1f) {
			slider.value = value;
			musicPlayer.volume = value;
		}
	}
	#endregion

	void Start () {
		getComponentsFindObjects();
		addEventsListeners();
		setVolume(PlayerPrefsManager.GetMasterVolume()); // Initial volume
	}

	void OnGUI () {
		if (GUI.Button(new Rect(10, 10, 100, 20), "default vol")) {
			SetDefaultVolume();
		}
	}
}
