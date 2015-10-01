using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public GameObject bullet;
	public float speed = 6;
	private int collisionCount;

	// Use this for initialization
	void Start () {
		collisionCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float movement_X = Input.GetAxis("Horizontal");
		float movement_Y = Input.GetAxis ("Vertical");
		transform.Translate (speed * movement_X, 0, 0);
		transform.Translate (0, speed * movement_Y, 0);

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name != "bullet(Clone)") {
			print ("Player Collided with: " + col.gameObject.name);
			collisionCount++;
			print ("Number of collisions with player: " + collisionCount);
			Destroy (col.gameObject);
		}
	}
}
