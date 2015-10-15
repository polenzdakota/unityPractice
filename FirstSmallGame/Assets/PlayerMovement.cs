using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour, EnemKillable {
	public GameObject bullet;
	public float speed = 6f;
	public int playerHP = 10;
	public float range = 10f;
	public GameObject LoseText;

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

	public void OnHit() {
		playerHP--;
		print (playerHP);
		if (playerHP < 1) {
			Destroy(gameObject);
			Instantiate(LoseText);
		}
	}

}
