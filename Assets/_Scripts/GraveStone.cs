using UnityEngine;
using System.Collections;

public class GraveStone : MonoBehaviour {
	private Animator anim;

	#region CustomMethods
	void GetComponentsAndObjects () {
	    anim = GetComponent<Animator>();
	}

	IEnumerator handleUnderAttack (GameObject other) {
	    print ("animartot"+ anim);
	    yield return null;
	}
	#endregion

	void Start () {
		GetComponentsAndObjects();
	}

	void OnTriggerStay2D (Collider2D other) {
	    if (other.GetComponent<Attacker>())
			StartCoroutine(handleUnderAttack(other.gameObject));
	}
}
