using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class LevelManager: MonoBehaviour {

	public GameObject downBread, egg, cheese, meat, vegetarian, upBread, plate;
	public SpriteRenderer downBreadSL, eggSL, cheeseSL, meatSL, vegetableSL, upBreadSL;
	public FallingFood ff;


	public static int currentID = 1;

	public string nextScene;

	public int slDownBread;
	public int slEgg;
	public int slCheese;
	public int slMeat;
	public int slVegetable;
	public int slUpBread;

	void Start(){
		FallingFood.isPlaying = true;
		currentID = 1;

		downBread.GetComponent<Food1> ().ID = slDownBread;
		egg.GetComponent<Food1> ().ID = slEgg;
		cheese.GetComponent<Food1> ().ID = slCheese;
		meat.GetComponent<Food1> ().ID = slMeat;
		vegetarian.GetComponent<Food1> ().ID = slVegetable;
		upBread.GetComponent<Food1> ().ID = slUpBread;

		downBreadSL.sortingOrder = slDownBread;
		eggSL.sortingOrder = slEgg;
		cheeseSL.sortingOrder = slCheese;
		meatSL.sortingOrder = slMeat;
		vegetableSL.sortingOrder = slVegetable;
		upBreadSL.sortingOrder = slUpBread;
	
		ff.Fall (downBread, 2, this);
		ff.Fall (egg, 3, this);
		ff.Fall (cheese, 7, this);
		ff.Fall (meat, 4, this);
		ff.Fall (vegetarian, 5, this);
		ff.Fall (upBread, 9, this);



	}

	public static void LoadScene(string nama){
		SceneManager.LoadScene (nama);
	}


}
