using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {
	void OnDrawGizmos () {
		BoxCollider2D box = GetComponent<BoxCollider2D>();
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube (transform.position, box.size);
	}

	void OnTriggerEnter2D (Collider2D other) {
		print("other"+ other);
		Destroy(other.gameObject);
	}
}
