using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public ProjectileShooter ProjectileGun;

	#region Custom Methods
	void shootProjectile() {
		ProjectileGun.FireProjectile();
	}
	#endregion
}
	