using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float size = 1;

	public float speed = 2;

	// Use this for initialization
	void Start () {
	}

	private void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "Water") {
			size += 0.01f;
		}
	}

	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Cloud") {
			Destroy(other.gameObject);
			size += 1;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");

		transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(size, 1, size), .2f);

		transform.position += new Vector3(x, 0, y) * Time.fixedDeltaTime * speed;
	}
}
