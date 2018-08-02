using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {
	[Range (0, 1)]public float WalkSpeed;

	#region Custom Methods
	void getComponentsFindObjects () {
		// Add a kinematic rigidBody to attackers
		Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
		rb.isKinematic = true;
	}

	void walkLeft() {
		float deltaSpace = Time.deltaTime * WalkSpeed;
		transform.Translate(Vector2.left * deltaSpace);
	}
	#endregion
	// Use this for initialization
	void Start () {
		getComponentsFindObjects();
	}
	
	// Update is called once per frame
	void Update () {
		walkLeft();
	}
}
