using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

	private Rigidbody rb;
	public float strength;
	private float x;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		rb.AddForce (transform.forward * strength);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		Destroy (gameObject);
	}
}
