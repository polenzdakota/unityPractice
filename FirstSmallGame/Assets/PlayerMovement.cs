using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public GameObject bullet;
	public float speed = 6;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float movement = Input.GetAxis("Horizontal");
		transform.Translate (speed * movement, 0, 0);

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}

	}
}
