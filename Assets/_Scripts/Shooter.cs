using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	private ProjectileShooter ps;

	#region Custom Methods
	void getComponentsAndObjects() {
		ps = transform.Find("ProjectileShooter").GetComponent<ProjectileShooter>();
	}

	void shootProjectile() {
		ps.FireProjectile();
	}
	#endregion
	// Use this for initialization
	void Start () {
		getComponentsAndObjects();
	}
}
