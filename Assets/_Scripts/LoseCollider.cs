using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager lm;

	#region CustomMethods
	void getComponentsAndObjects ()
	{
		lm = GameObject.Find("Level Manager").GetComponent<LevelManager>();
	}
	#endregion

	void Start () {
		getComponentsAndObjects();	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.GetComponent<Attacker>()) {
			lm.changeScene("3b_LoseScene");
		}
	}

	void OnDrawGizmos () {
		BoxCollider2D box = GetComponent<BoxCollider2D>();
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (transform.position, box.size);
	}
}
