using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puddle : MonoBehaviour {

	public float water = 10;

	private void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "Player") {
			water -= 0.05f;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (water <= 0) {
			Destroy(gameObject);
		}
	}
}
