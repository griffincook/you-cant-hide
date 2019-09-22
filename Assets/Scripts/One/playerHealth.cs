using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	public Transform slender;
	private float killrange = 5.0f;
	public ParticleSystem chains;
	private float warningRange = 20.0f;
	private int health = 10;
	public GUIText healthText;
	public GUIText loseText;
	public GUIText keysText;
	public GUIText introText;
	private float timeLim;
	private float attackPause;
	private float keys;
	public GameObject introMushroom;
	public GameObject restart;


	// Use this for initialization
	void Start () {
		healthText.text = "Health: " + health;
		loseText.text = "";
		keysText.text = "Keys: " + keys + "/10";
		timeLim = 0;
		attackPause = 1.0f;
		keys = 0;
	}

	// Update is called once per frame
	void Update () {
		//distance between player and main enemy
		float distance = Vector3.Distance(transform.position, slender.position);
		//player dies if too close to it
		if (distance < killrange) {
			healthText.text = "";
			introText.text = "";
			loseText.text = "YOU LOSE, press 'r' to restart";
			restart.SetActive (true);
			gameObject.SetActive (false);
		}
		//visual warning when he's close
		if (distance < warningRange) {
			Instantiate (chains, transform);
		}
	}

	void OnTriggerStay (Collider other) {
		if (other.tag == "Mushroom") {
			if (Time.time > timeLim) {
				health = health - 1;
				healthText.text = "Health: " + health;
				timeLim = Time.time + attackPause;
			}
			if (health == 0) {
				healthText.text = "";
				introText.text = "";
				loseText.text = "YOU LOSE, press 'r' to restart";
				restart.SetActive (true);
				gameObject.SetActive (false);
			}
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "key") {
			//add 0.5 because the noise collider also collides, causing two collisions, score goes up 1
			keys = keys + 0.5f;
			keysText.text = "Keys: " + keys + "/10";
			Destroy (other.gameObject);
			if (keys == 1) {
				introText.text = "Now destroy the mushroom to start. This one can't hurt you... * Hold Left Click To Hit Mushrooms *";
				introMushroom.SetActive (true);
			}
		}
		else if (other.tag == "GoodMushroom") {
			if (keys == 10) {
				SceneManager.LoadScene ("boss");
			} else {
				introText.text = "Bring me the 10 keys if you want a chance to escape!";
			}
		}
		else if (other.tag == "FunGuyTrigger") {
			introText.text = "Hey! You look like a fun guy, come closer!";
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "GoodMushroom") {
			introText.text = "";
		} 
		else if (other.tag == "FunGuyTrigger") {
			introText.text = "";
		}
	}
}
