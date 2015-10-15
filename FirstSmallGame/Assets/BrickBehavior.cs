using UnityEngine;
using System.Collections;

public class BrickBehavior : MonoBehaviour, EnemKillable {
	public int brickHP = 3;
	public float brickSpeed = 2;
	public int range = 10;
	public float initialX;
	// Use this for initialization
	void Start () {
		initialX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		MoveBackAndForth (brickSpeed);
	}

	/// <summary>
	/// Called on hit with projectile.
	/// </summary>
	public void OnHit() {
		brickHP--;
		if (brickHP < 1) {
			Destroy (gameObject);
		}
	}

	public void MoveBackAndForth(float speed) {
		transform.Translate (speed, 0, 0);
		float position = transform.position.x;
		float maxRangePos = range + initialX;
		float maxRangeNeg = -range + initialX; 

		if((position > 0 && position > maxRangePos) || (position < 0 && position < maxRangeNeg)) {
			brickSpeed = -brickSpeed;
		}
	}
}
