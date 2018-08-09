using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Food1 : MonoBehaviour {

	public int ID;

	public LevelManager lm;

	FallingFood ff = new FallingFood();

	public void OnCollisionEnter2D (Collision2D coll){
		if (!enabled)
			return;
		Scene currentScene = SceneManager.GetActiveScene();
		string sceneName = currentScene.name;

		if (coll.gameObject == FallingFood.bawah) {
			this.gameObject.transform.parent = FallingFood.bawah.transform;
			FallingFood.bawah = gameObject;

			if (LevelManager.currentID == ID) {
				LevelManager.currentID++;
			} else {
				FallingFood.isPlaying = false;
				HealthBar.healthbarred += 30.34f;
			}

			if (LevelManager.currentID == 7) {
				FallingFood.isPlaying = false;
				HealthBar.healthbargreen += 30.34f;
			}
			enabled = false;
		}

		if (coll.gameObject.tag == "ground") {
			Object.Destroy (this.gameObject);
		}

	}
	
}
