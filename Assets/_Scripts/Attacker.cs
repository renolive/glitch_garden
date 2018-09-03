using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

	private float walkSpeed;
	private GameObject target;
	private Action onEmptyTarget = () => {};

	[Tooltip ("Average number of seconds between appearances")]
	public float seenEverySeconds;

	#region Custom Method
	void checkTarget () {
	    if (!target) {
	        onEmptyTarget();
	    }
	}

	void getComponentsFindObjects () {
	}

	public void SetOnEmptyTarget(Action handleEmptyTarget) {
		onEmptyTarget = handleEmptyTarget;
	}
	public void SetTarget (GameObject target) {
	    this.target = target;
	}
	public void SetWalkSpeed(float speed) {
	    walkSpeed = speed;
	}

	public void StrikeTarget (float damage) {
	    if (target) {
			Health targetHealth = target.GetComponent<Health>();
			targetHealth.TakeDamage(damage);
	    }
	}

	void walkLeft() {
		float deltaSpace = Time.deltaTime * walkSpeed;
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
		checkTarget();
	}
}
