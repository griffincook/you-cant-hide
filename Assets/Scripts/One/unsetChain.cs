using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unsetChain : MonoBehaviour {

	private float time;

	// Use this for initialization
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > time + 7) {
			Destroy (gameObject);
		}
	}
}
