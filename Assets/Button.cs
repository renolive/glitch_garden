using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	private SpriteRenderer sp;
	private Button[] defendersButtons;

	public static GameObject selectedDefender {get;set;}
	public GameObject defenderPrefab;

	#region Custom Methods
	void getComponentsAndObjects () {
		sp = GetComponent<SpriteRenderer>();
		defendersButtons = GameObject.FindObjectsOfType<Button>();
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
		print(selectedDefender);
	}

	#endregion

	// Use this for initialization
	void Start () {
		getComponentsAndObjects();
	}

	void OnMouseDown () {
		handleButtonClick();
	}
}
