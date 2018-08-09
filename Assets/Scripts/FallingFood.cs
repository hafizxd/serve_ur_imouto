using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class FallingFood{

	public GameObject foodGenerator;
	public static GameObject atas;
	public static GameObject bawah;
	public Transform left, right;
	public static bool isPlaying = true;


	public void Fall(GameObject food, float timeToSpawn, MonoBehaviour mono){
		mono.StartCoroutine (StartGenerate (food, timeToSpawn));
	}

	public IEnumerator StartGenerate(GameObject thing, float angka){
		while (isPlaying) {
			yield return new WaitForSeconds (angka);
			float xPosition = Random.Range (left.position.x, right.position.x);
			GameObject _food = Object.Instantiate (thing, new Vector2 (xPosition, Camera.main.orthographicSize + 1),
				Quaternion.identity) as GameObject;
		}

	}


}
