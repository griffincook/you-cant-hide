using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireShot : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		rb.AddForce (new Vector3 (0.0f, 0.8f, 1.0f) * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
