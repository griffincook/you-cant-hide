using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redMushroom : MonoBehaviour {

	private Rigidbody rb;
	private float timeWait;
	private float rand;

	void Start () {
		rb = GetComponent <Rigidbody> ();
		timeWait = 0;
		rand = Random.value;
	}

	void FixedUpdate () {
		Vector3 velo = rb.velocity;
		if (Time.time > timeWait) {
			rand = Random.Range (0.0f, 1.0f);
			timeWait = Time.time + 2;
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
			velo.x = -10;
			velo.z = 0;
			velo.y = 0;
			rb.velocity = velo;
		}
	}
}
