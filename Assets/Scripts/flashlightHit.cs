using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightHit : MonoBehaviour {

	private float hits;

	void Start () {
		hits = 0;
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "flashlight") {
			//increase amount of hits against flashlight
			hits++;
			//destroy mushroom after 1 hit
			if (hits == 1) {
				Destroy (gameObject);
			}
		}	
	}
}
