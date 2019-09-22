using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomSpawnControl : MonoBehaviour {

	public GameObject [] mushroomArray;
	public Transform [] spawnArray;
	private float timeWait;
	private int rand;
	private int randLoc;

	// Use this for initialization
	void Start () {
		timeWait = Time.time + 8;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeWait) {
			rand = Random.Range (0, 6);
			randLoc = Random.Range (0, 3);
			Instantiate (mushroomArray[rand], spawnArray[randLoc]);
			timeWait = Time.time + 3;
		}
	}
}
