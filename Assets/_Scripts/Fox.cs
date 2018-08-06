using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]

public class Fox : MonoBehaviour {
	private Attacker attacker;
	private Animator anim;

	#region Custom Methods
	void getComponentsAndObjects() {
	    anim = GetComponent<Animator>();
	    attacker = GetComponent<Attacker>();
	}

	void handleEmptyTarget() {
	    if (anim.GetBool("isAttacking")) {
	        anim.SetBool("isAttacking", false);
	    }
	}

	void setHandlersAndListeners() {
		attacker.SetOnEmptyTarget(handleEmptyTarget);
	}

	void handleTriggerEnterDefender (GameObject defender) {
		if (defender.GetComponent<GraveStone>()) {
            anim.SetTrigger("toJump"); 
        } else {
            anim.SetBool("isAttacking", true);
			attacker.SetTarget(defender);
        }
	}
	#endregion

	void Start () {
		getComponentsAndObjects();
		setHandlersAndListeners();
	}

	void OnTriggerEnter2D (Collider2D other) {
	    GameObject otherObj = other.gameObject;

	    if (otherObj.GetComponent<Defender>()) {
	        handleTriggerEnterDefender(otherObj);
	    }
	    return;
	}
}
