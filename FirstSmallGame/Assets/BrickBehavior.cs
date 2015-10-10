using UnityEngine;
using System.Collections;

public class BrickBehavior : MonoBehaviour, EnemKillable {

	public int brickHP = 3;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	/// <summary>
	/// Called on hit with projectile.
	/// </summary>
	public void OnHit() {
		brickHP--;
		print (brickHP);
		if (brickHP < 1) {
			Destroy (gameObject);
		}
	}
}
