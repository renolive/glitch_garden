using UnityEngine;
using System.Collections;

public class GraveStone : MonoBehaviour {
	private Animator anim;

	#region CustomMethods
	void GetComponentsAndObjects () {
	    anim = GetComponent<Animator>();
	}

	IEnumerator handleUnderAttack (Collider2D other) {
		anim.SetBool("underAttack", true);
		while (other.isActiveAndEnabled){
			yield return new WaitForSeconds(.1f);
		}
		anim.SetBool("underAttack", false);
	}
	#endregion

	void Start () {
		GetComponentsAndObjects();
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.GetComponent<Attacker>()) {
			StartCoroutine(handleUnderAttack(other));
		}
	}
}
