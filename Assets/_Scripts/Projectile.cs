using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed, damage;

	void Update () {
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
