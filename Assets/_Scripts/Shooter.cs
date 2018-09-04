using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Shooter : MonoBehaviour {
	private Animator anim;
	private Spawner laneSpawner;

	public ProjectileShooter ProjectileGun;

	#region Custom Methods
	void getComponentsAndObjects ()
	{
		anim = gameObject.GetComponent<Animator>();
		laneSpawner = getSpawnerInLane(transform.position.y);
	}

	/**
	 * Find the spawner on same lane of this shooter
	 */
	Spawner getSpawnerInLane(float lane) {
		Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();
		foreach(Spawner spawner in spawnerArray) {
			if (spawner.transform.position.y == lane) { return spawner; }
		}
	    Debug.LogError("No spawner found for lane: "+ transform.position.y);
	    return null;

	}

	bool laneHasEnemy() {
		// Check if the laneSpawner has children and if one of them is ahead the shooter
		if (laneSpawner.transform.childCount > 0) {
			foreach(Transform child in laneSpawner.transform) {
				if (child.position.x > transform.position.x) { return true; }
			}
		}
		return false;
	}

	void verifyEnemiesInLane() {
	    if (laneHasEnemy()) {
	        anim.SetBool("isAttacking", true);
	    } else {
	        anim.SetBool("isAttacking", false);
	    }
	}

	void shootProjectile() {
		ProjectileGun.FireProjectile();
	}
	#endregion

	void Start() {
		getComponentsAndObjects();
	}

	void Update() {
	    verifyEnemiesInLane();
	}
}
	