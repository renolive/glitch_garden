using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed, damage;

	void Update () {
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D other) {
		Attacker otherAttacker = other.GetComponent<Attacker>();
		Health otherHealth = other.GetComponent<Health>();

		// projectiles only cause damage to Attackers
		if (otherHealth && otherAttacker) {
			otherHealth.TakeDamage(damage);
			Destroy(gameObject);
		}
	}
}
