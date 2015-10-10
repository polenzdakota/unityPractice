using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public GameObject bullet;
	public float speed = 6;
	public int playerHP = 10;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float movement_X = Input.GetAxis("Horizontal");
		transform.Translate (speed * movement_X, 0, 0);

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name != "bullet(Clone)") {
			print ("Player Collided with: " + col.gameObject.name);
			playerHP--;
			print ("Number of collisions with player: " + playerHP);
		}
	}
}
