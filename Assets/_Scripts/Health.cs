using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float remainingHealth;

	public float GetHealth () {
	    return remainingHealth;
	}

	public void TakeDamage (float damage) {
		remainingHealth -= damage;

		print("!!Taking Damage "+ name+ " "+ remainingHealth);
		// If is dead
		if (remainingHealth <= 0) {
	        Destroy(gameObject);
	    }
	}
}
