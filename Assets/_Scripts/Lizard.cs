using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]

public class Lizard : MonoBehaviour {
	private Attacker attacker;
	private Animator anim;

	#region Custom Methods
	void getComponentsFindObjects() {
	    anim = GetComponent<Animator>();
	    attacker = GetComponent<Attacker>();
	}

	void handleTriggerEnterDefender (GameObject defender) {
        anim.SetBool("isAttacking", true);
		attacker.SetTarget(defender);
	}
	#endregion

	// Use this for initialization
	void Start () {
		getComponentsFindObjects();
	}

	void OnTriggerEnter2D (Collider2D other) {
	    GameObject otherObj = other.gameObject;

	    if (otherObj.GetComponent<Defender>()) {
	        handleTriggerEnterDefender(otherObj);
	    }
	    return;
	}

}
