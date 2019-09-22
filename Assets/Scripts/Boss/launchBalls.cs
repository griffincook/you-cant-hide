using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchBalls : MonoBehaviour {

	public GameObject ball;
	private float wait;

	// Use this for initialization
	void Start () {
		wait = Time.time + 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > wait) {
			Instantiate (ball, transform);
			transform.DetachChildren();
			wait = Time.time + 3;
		}
	}
}
