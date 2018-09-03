using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {
	public List<GameObject> attackerPrefabArray;

	/**
	 * A very bad approach to spawner timer
	 */
	bool isTimeToSpawn(float spawnRate) {
		if (Time.deltaTime > spawnRate) {
			Debug.LogWarning ("Spawn rate capped by frame rate");
		}

		float treshold = (1 / spawnRate) * Time.deltaTime;
		return Random.value < treshold/5 ? true : false;
	}

	void Spawn(GameObject myGameObject) {
		GameObject newGameObject = Instantiate(myGameObject, transform.position, Quaternion.identity) as GameObject;
		newGameObject.transform.SetParent(transform);
	}

	void spawnRoutine() {
		attackerPrefabArray.ForEach(attacker => {
			if (isTimeToSpawn(attacker.GetComponent<Attacker>().seenEverySeconds)) {
				Spawn(attacker);
			}
		});
	}

	void Update () {
		spawnRoutine();
	}
}
