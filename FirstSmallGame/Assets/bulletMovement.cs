using UnityEngine;
using System.Collections;

public class bulletMovement : MonoBehaviour {
	public float bulletSpeed = 5;
	private int collisionCount;
	// Use this for initialization
	void Start () {
		collisionCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, bulletSpeed, 0);
		if (transform.position.y > 50) {
			DestroyObject (gameObject);
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name != "Player") {
			print ("Bullet Collided with: " + col.gameObject.name);
			collisionCount++;
			print ("Number of collisions with Bullet: " + collisionCount);
			Destroy (col.gameObject);
		}
	}
}
