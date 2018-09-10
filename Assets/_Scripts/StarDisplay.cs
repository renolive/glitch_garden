using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {
	private Text display;
	private int totalStars;

	#region CustomMethods
	void GetComponentsAndObjects ()
	{
		display = transform.GetComponent<Text>();
		Int32.TryParse(display.text, out totalStars);
	}

	public void IncrementStars (int amount)
	{
	    totalStars += amount;
	    UpdateDisplay();
	}

	public bool UseStars (int amount) {
	    if (totalStars >= amount) {
	        totalStars -= amount;
			UpdateDisplay();
	        return true;
	    }
	    return false;
	}

	public void UpdateDisplay () {
	    display.text = totalStars.ToString();
	}
	#endregion

	void Start () {
		GetComponentsAndObjects();

	}

	void OnGUI () {
		if (GUI.Button (new Rect(Screen.width * (0.7f), 10, 70, 20), "Use Stars")) {
		    UseStars(1);
		}
	}
}
