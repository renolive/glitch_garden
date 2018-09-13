using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {
	private SpriteRenderer sp;
	private Button[] defendersButtons;
	private Text cost;

	public static GameObject selectedDefender {get;set;}
	public GameObject defenderPrefab;

	#region Custom Methods
	void getComponentsAndObjects () {
		sp = GetComponent<SpriteRenderer>();
		defendersButtons = GameObject.FindObjectsOfType<Button>();
		cost = GetComponentInChildren<Text>();
	}

	void highlightsClickedButton() {
		// blackout all defenders
		foreach(Button defender in defendersButtons) {
			defender.GetComponent<SpriteRenderer>().color = Color.black;
		}
		// highlights the selected defender
		sp.color = Color.white;
	}

	void handleButtonClick() {
		highlightsClickedButton();
		selectedDefender = defenderPrefab;
	}

	void SetCostDisplay() {
		if (cost) {
			cost.text = defenderPrefab.GetComponent<Defender>().Cost.ToString();
		}
	}
	#endregion

	// Use this for initialization
	void Start () {
		getComponentsAndObjects();
		SetCostDisplay();
	}

	void OnMouseDown () {
		handleButtonClick();
	}
}
