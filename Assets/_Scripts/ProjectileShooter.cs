using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {

	public GameObject projectile;

	public void FireProjectile() {
		GameObject newProjectile = GameObject.Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
	}
}
