using UnityEngine;
using System.Collections;

public class EnemHPControler : MonoBehaviour {
	public int playerTwoHp = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DecreaseHP() {
		playerTwoHp--;
		print ("enem hp decreased!");
		Vector3 scale = transform.localScale;
		scale.y = playerTwoHp;
		transform.localScale = scale;
	}
}
