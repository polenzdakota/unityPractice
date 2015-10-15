using UnityEngine;
using System.Collections;

public class EnemyBu : MonoBehaviour {
	public float enemBulletSpeed = 0.5f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -enemBulletSpeed, 0);
		if (transform.position.y < -50) {
			DestroyObject (gameObject);
		}
	}

	void OnTriggerEnter(Collider col) {
			//Envokes OnKill from interface
		if(col.gameObject.name == "Player") {
			col.gameObject.GetComponent<EnemKillable>().OnHit();
			Destroy (gameObject);
		}
	}
}
