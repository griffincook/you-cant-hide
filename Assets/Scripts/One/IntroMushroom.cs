using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMushroom : MonoBehaviour {

	public GameObject slenderController;
	public GameObject mushrooms;
	public GameObject walls;
	public GUIText introText;
	public GameObject minimap;
	public GameObject music;
	public GameObject wind;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "flashlight") {
			introText.text = "";
			slenderController.SetActive (true);
			mushrooms.SetActive (true);
			minimap.SetActive (true);
			music.SetActive (true);
			wind.SetActive (false);
			Destroy (walls.gameObject);
		}
	}
}
