using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomHit : MonoBehaviour {

	private int ammo=0;
	public GUIText ammoText;
	public GameObject shot;
	public GameObject spawnPoints;
	public GameObject slender;
	public GameObject music;
	public GameObject crickets;

	// Use this for initialization
	void Start () {
		ammoText.text = "Shots: " + ammo;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {	
			if (ammo > 0) {
				Instantiate (shot, transform);
				transform.DetachChildren();
				ammo = ammo - 1;
				ammoText.text = "Shots: " + ammo;
			}
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "RedMushroom") {
			ammo = ammo + 1;
			ammoText.text = "Shots: " + ammo;
		}
		if (other.tag == "InitialMushroom") {
			ammo = ammo + 1;
			ammoText.text = "Shots: " + ammo;
			spawnPoints.SetActive (true);
			slender.SetActive (true);
			music.SetActive (true);
			crickets.SetActive (false);
		}
	}
}
