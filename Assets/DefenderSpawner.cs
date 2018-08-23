using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	private Camera cam;
	private GameObject defendersParent;

	#region CustomMethods
	void getComponentsAndObjects () {
		cam = Camera.main;
		defendersParent = GameObject.Find("Defenders");
	}

	void getPositionInWorldUnits() {
		Vector3 rawWorldUnits = cam.ScreenToWorldPoint(Input.mousePosition);
		Vector3 roundedWorldUnits = new Vector3(Mathf.Round(rawWorldUnits.x), Mathf.Round(rawWorldUnits.y), 0);

		instantiateDefender(roundedWorldUnits);
	}

	void instantiateDefender(Vector3 pos) {
		// Only instantiate static var Button.selectedDefender has a defender
		if (Button.selectedDefender){
			Instantiate(Button.selectedDefender, pos, Quaternion.identity);
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
