using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {
	private GameObject projectileParent;
	public GameObject projectile;

	#region Custom Methods
	public void FireProjectile() {
		GameObject newProjectile = GameObject.Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
	}

	void getComponentsAndObjects ()
	{
		projectileParent = GameObject.Find("Projectiles");
		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}

	}
	#endregion

	void Start() {
		getComponentsAndObjects();
	}
}
