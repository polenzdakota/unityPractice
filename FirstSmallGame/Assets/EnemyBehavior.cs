using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour, EnemKillable {
	public GameObject EnemBullet;
	public int enemHP = 10;
	public int range = 10;
	public float enemSpeed = 0.5f;
	private float initialX;
	public float frequency = 1f;
	private float timedFire;
	private float startTime;
	private float prevTime = 0.0f;
	public GameObject WinText;

	// Use this for initialization
	void Start () {
		initialX = transform.position.x;
		startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		timedFire = Time.time - startTime - prevTime;
		if (timedFire > frequency) {
			FireBullet();
			prevTime = Time.time;
			timedFire = 0;
		}
		MoveBackAndForth (enemSpeed);
	}

	public void OnHit() {
		enemHP--;
		if (enemHP < 1) {
			Destroy (gameObject);
			Instantiate(WinText);
		}
	}

	public void FireBullet() {
		Instantiate (EnemBullet, transform.position, transform.rotation);
	}

	public void MoveBackAndForth(float speed) {
		transform.Translate (speed, 0, 0);
		float position = transform.position.x;
		float maxRangePos = range + initialX;
		float maxRangeNeg = -range + initialX; 
		
		if((position > 0 && position > maxRangePos) || (position < 0 && position < maxRangeNeg)) {
			enemSpeed = -enemSpeed;
		}
	}
}
