using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jab : MonoBehaviour {

	//time to extend and retract
	public float smoothTime = 0.1f;
	private Vector3 smoothVelocity = Vector3.zero;
	//empty game objects for position to extend to
	public Transform extend;
	public Transform retract;
	public GameObject spotlight;

	void FixedUpdate () {
		//hold to extend
		if (Input.GetButton ("Fire1")) {
			transform.position = Vector3.SmoothDamp (transform.position, extend.position, ref smoothVelocity, smoothTime);
			spotlight.SetActive (false);		
		}
		//hold to retract
		else {
			transform.position = Vector3.SmoothDamp (transform.position, retract.position, ref smoothVelocity, smoothTime);
			spotlight.SetActive (true);
		}
	}
}
