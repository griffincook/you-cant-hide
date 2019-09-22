using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battlePlayer : MonoBehaviour {

	public float health = 30;
	public GUIText loseText;
	public GUIText healthText;
	public GameObject endCam;
	public GameObject character;
	public GameObject restart;
	public GameObject ui;

	private float timeLim = 0;
	public float attackPause = 0.5f;

	// Use this for initialization
	void Start () {
		loseText.text = "";
		healthText.text = "Health: " + health;
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0) {
			loseText.text = "You Lose! Press 'r' to retry the boss fight, or 's' to restart the game";
			endCam.SetActive (true);
			restart.SetActive (true);
			ui.SetActive (false);
			character.SetActive (false);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Fireball") {
			health = health - 1;
			healthText.text = "Health: " + health;
		}
	}

	void OnTriggerStay (Collider other) {
		if (other.tag == "Mushroom") {
			if (Time.time > timeLim) {
				health = health - 1;
				healthText.text = "Health: " + health;
				timeLim = Time.time + attackPause;
			}
		}
	}
}
