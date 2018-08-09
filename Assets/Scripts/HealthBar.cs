using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public Image healthBarGreen;
	public Image healthBarRed;
	float maxHealth = 100f;
	public static float healthbargreen;
	public static float healthbarred;

	// Use this for initialization
	void Start () {
		//healthbargreen = maxHealth;
		//healthbarred = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		healthBarGreen.fillAmount = healthbargreen / maxHealth;
		healthBarRed.fillAmount = healthbarred / maxHealth;
	}
}
