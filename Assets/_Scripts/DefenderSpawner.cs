using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	private Camera cam;
	private GameObject defendersParent;
	private StarDisplay starDisplay;

	#region CustomMethods
	void getComponentsAndObjects () {
		cam = Camera.main;
		defendersParent = GameObject.Find("Defenders");
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

	void getPositionInWorldUnits() {
		Vector3 rawWorldUnits = cam.ScreenToWorldPoint(Input.mousePosition);
		Vector3 roundedWorldUnits = new Vector3(Mathf.Round(rawWorldUnits.x), Mathf.Round(rawWorldUnits.y), 0);

		instantiateDefender(roundedWorldUnits);
	}

	void instantiateDefender(Vector3 pos) {
	    Defender selectedDefender = Button.selectedDefender.GetComponent<Defender>();
//	    int defenderCost = selectedDefender.GetComponent<Defender>();

		// Instatiation conditions: have enough stars and a defender is selected in Button class
		if (selectedDefender && starDisplay.UseStars(selectedDefender.Cost)){
			GameObject defender = Instantiate(Button.selectedDefender, pos, Quaternion.identity) as GameObject;
			defender.transform.parent = defendersParent.transform;
		} else {
			print ("You don't have enough stars");
		}
	}
	#endregion

	void Start() {
		getComponentsAndObjects();
	}

	void OnMouseDown() {
		getPositionInWorldUnits();
	}
}
