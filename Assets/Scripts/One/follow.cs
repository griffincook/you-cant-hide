using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public Transform player;
	public float smoothTime = 7.0f;
	private Vector3 smoothVelocity = Vector3.zero;

	void Start() {
	}

	void Update () {
		//Look at Player
		transform.LookAt(player);
		//move towards player
		transform.position = Vector3.SmoothDamp (transform.position, player.position, ref smoothVelocity, smoothTime);
	}
}
