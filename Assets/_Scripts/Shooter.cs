using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	private Animator anim;
	private Spawner sp;

	public ProjectileShooter ProjectileGun;

	#region Custom Methods
	void getComponentsAndObjects ()
	{
		anim = gameObject.GetComponent<Animator>();
		sp = getSpawnerInLane(transform.position.y);
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
	