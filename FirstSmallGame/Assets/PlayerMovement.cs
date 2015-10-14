using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public GameObject bullet;
	public float speed = 6f;
	public int playerHP = 10;
	public float range = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float movement_X = Input.GetAxis("Horizontal");


		if (bounds (movement_X)) {
			transform.Translate (speed * movement_X, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	bool bounds(float movement_X) {
		return ((transform.position.x <= range && transform.position.x >= -range) ||
			(transform.position.x > range && movement_X < 0) ||
			(transform.position.x < -range && movement_X > 0));
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name != "bullet(Clone)") {
			playerHP--;
		}
	}
}
