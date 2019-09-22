using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomBoss : MonoBehaviour {

	private GameObject player;
	private Vector3 playerPos;

	public float tooClose = 2.5f;
	private Vector3 smoothVelocity = Vector3.zero;
	public float smoothTime = 2.0f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		playerPos = player.transform.position;

		//Look at Player
		transform.LookAt (playerPos);
		//distance to player
		float distance = Vector3.Distance (transform.position, playerPos);

		if (distance > tooClose) {
			//move towards player
			transform.position = Vector3.SmoothDamp (transform.position, playerPos, ref smoothVelocity, smoothTime);
		}
	}
}
