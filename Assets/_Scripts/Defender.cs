using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	private StarDisplay starDisplay;

	public int Cost = 100;

	#region CustomMethods
	public void AddStars (int amount)
	{
		starDisplay.IncrementStars(amount);
	}

	void GetComponentsAndObjects ()
	{
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
	}
	#endregion
	 
	// Use this for initialization
	void Start () {
		GetComponentsAndObjects();
	}
}
