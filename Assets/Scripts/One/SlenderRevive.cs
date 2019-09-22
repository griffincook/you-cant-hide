using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderRevive : MonoBehaviour {

	public GameObject slender;
	public Transform slenderTransform;
	private float timeActivate;
	private float timeDeactivate;
	private bool checkActive;
	private Vector3 position;

	//private playerHealth script;

	// Use this for initialization
	void Start () {
		checkActive = false;
		//script = playerHealth.GetComponent<playerHealth> ();
	}

	// Update is called once per frame
	void Update () {
		if (checkActive == false) {
			if (slender.activeInHierarchy == false) {
				timeActivate = Time.time;
				timeDeactivate = Time.time + 1000;
				checkActive = true;
			} else if (slender.activeInHierarchy == true) {
				timeDeactivate = Time.time;
				timeActivate = Time.time + 1000;
				checkActive = true;
			}
		} 

		else {
			if (timeActivate < Time.time - 60) {
				slender.SetActive (true);
				checkActive = false;
				position = slenderTransform.position;
				position.y = 2.3f;
				slenderTransform.position = position;
			} else if (timeDeactivate < Time.time - 40) {
				slender.SetActive (false);
				checkActive = false;
				position = slenderTransform.position;
				position.y = 1000f;
				slenderTransform.position = position;
			}
		}
	}
}
