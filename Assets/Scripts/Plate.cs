using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {


	public string nextScene;
	public GameObject[] upObj;

	void Start () {

		foreach (GameObject obj in upObj) {
			obj.gameObject.GetComponent<Food1> ().enabled = true;
		}

		FallingFood.isPlaying = true;

		FallingFood.bawah = this.gameObject;
		if (FallingFood.bawah == this.gameObject) {
			Debug.Log (this.gameObject);
		}

		this.gameObject.transform.tag = "Down";
		
	}

	public float speed;

	void Update(){
		
		if (Input.GetKey ("d") && FallingFood.isPlaying) {
			if (this.gameObject.transform.position.x > -9 && this.gameObject.transform.position.x < 8) {
				transform.Translate (speed * Time.deltaTime, 0, 0, Camera.main.transform);
			}
		} else if (Input.GetKey ("a") && FallingFood.isPlaying) {
			if (this.gameObject.transform.position.x < 9 && this.gameObject.transform.position.x > -8) {
				transform.Translate (-speed * Time.deltaTime, 0, 0, Camera.main.transform);
			}
		}

		if (!FallingFood.isPlaying) {
			foreach (GameObject obj in upObj) {
				obj.gameObject.GetComponent<Food1> ().enabled = false;
			}
			StartCoroutine (ChangeScene ());
		}


	}

	IEnumerator ChangeScene(){
		transform.Translate (-speed * Time.deltaTime, 0, 0, Camera.main.transform);
		yield return new WaitForSeconds (1.5f);
		LevelManager.LoadScene (nextScene);
	}


		

}
