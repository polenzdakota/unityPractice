﻿using UnityEngine;
using System.Collections;

public class bulletMovement : MonoBehaviour {
	public float bulletSpeed = 5f;
	// Use this for initialization
	void Start () {
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
			Destroy (gameObject);
			//Envokes OnKill from interface
			col.gameObject.GetComponent<EnemKillable>().OnHit();
		}
	}
}
