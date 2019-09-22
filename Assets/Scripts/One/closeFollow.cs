using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeFollow : MonoBehaviour {

	public Transform player;
	public float smoothTime = 1.0f;
	public float proximity = 40.0f;
	public float tooClose = 2.5f;
	private Vector3 smoothVelocity = Vector3.zero;
	private Vector3 direction;
	private Rigidbody rb;
	private float timeWait;
	private float rand;
	private float audioTime;

	void Start () {
		rb = GetComponent <Rigidbody> ();
		timeWait = 0;
		rand = Random.value;
		audioTime = 0;
	}

	void FixedUpdate () {
		//Look at Player
		transform.LookAt(player);
		//distance to player
		float distance = Vector3.Distance(transform.position, player.position);
		//random movement when far from player
		if (distance > proximity) {
			
			Vector3 velo = rb.velocity;
			if (Time.time > timeWait) {
				rand = Random.Range (0.0f, 1.0f);
				timeWait = Time.time + 5;
			}
			//movement depending on random number
			if (0.125f >= rand) {
				velo.x = 10;
				velo.z = 0;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.125f < rand && rand <= 0.25f) {
				velo.x = 10 * rand;
				velo.z = 10 * rand;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.25f < rand && rand <= 0.375f) {
				velo.x = 0;
				velo.z = 10 * rand;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.375f < rand && rand <= 0.5f) {
				velo.x = 10 * rand;
				velo.z = -10 * rand;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.5f < rand && rand <= 0.625f) {
				velo.x = 0;
				velo.z = -10 * rand;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.5f < rand && rand <= 0.625f) {
				velo.x = -10 * rand;
				velo.z = 10 * rand;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.625f < rand && rand <= 0.75f) {
				velo.x = -10 * rand;
				velo.z = 0;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.75f < rand && rand <= 0.875f) {
				velo.x = -10 * rand;
				velo.z = -10 * rand;
				velo.y = 0;
				rb.velocity = velo;
			} else if (0.875f < rand && rand <= 1.0f) {
				velo.x = 0;
				velo.z = 0;
				velo.y = 0;
				rb.velocity = velo;
			}
		}

		//if close enough to player
		else if (distance < proximity) {
			if (distance > tooClose) {
				//move towards player
				transform.position = Vector3.SmoothDamp (transform.position, player.position, ref smoothVelocity, smoothTime);
			}
			//set limit so audio doesnt overlap
			if (Time.time > audioTime) {
				GetComponent<AudioSource> ().Play ();
				audioTime = Time.time + 13.5f;
			}
		}
	}
}
