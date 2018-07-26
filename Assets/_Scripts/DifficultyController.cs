using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DifficultyController : MonoBehaviour {
	Slider slider;

	public int DefaultValue;

	#region Custom Methods
	void addEventsListeners () {
		slider.onValueChanged.AddListener(delegate {setDifficulty((int)slider.value);});
	}

	void getComponentsFindObjects () {
		slider = transform.Find("Slider").GetComponent<Slider>();
	}

	public void SaveDifficulty () {
		PlayerPrefsManager.SetDifficulty((int)slider.value);
		print(PlayerPrefsManager.GetDifficulty());
	}

	public void SetDefaultDifficulty () {
		setDifficulty(DefaultValue);
	}

	void setDifficulty (int value) {
		if (value >= 1 && value <= 3) {
			slider.value = value;
		}
	}
	#endregion

	void Start () {
		getComponentsFindObjects();
		addEventsListeners();
		setDifficulty(PlayerPrefsManager.GetDifficulty()); // Initial volume
	}

	void OnGUI () {
		if (GUI.Button(new Rect(10, 40, 100, 20), "default diff")) {
			SetDefaultDifficulty();
		}
	}

}
