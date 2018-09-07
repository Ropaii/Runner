using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {

	public Obstacle obstacle;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (obstacle, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
