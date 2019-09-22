using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class slenderBoss : MonoBehaviour {

	public float speed;
	public Transform player;
	private float health = 1000;
	public GUIText bossHealthText;


	// Use this for initialization
	void Start () {
		bossHealthText.text = "Boss Health: " + health;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//make it rotate around y axis to look at player
		Vector3 targetPos = new Vector3 (player.position.x, transform.position.y, player.position.z);
		transform.LookAt (targetPos);
		//make it move side to side
		transform.position = new Vector3 (Mathf.PingPong (Time.time * speed, 25)-12.5f, transform.position.y, transform.position.z);
	}

	void Update () {
		if (health <= 0) {
			SceneManager.LoadScene ("end");
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Shot") {
			health = health - 100;
			bossHealthText.text = "Boss Health: " + health;
			GetComponent<AudioSource> ().Play ();
			Destroy (other.gameObject);
		}
	}
}
