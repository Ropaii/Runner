using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	private Obstacle obstacle;
	// Use this for initialization
	void Start () {
		obstacle = GetComponent<Obstacle> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left * obstacle.speed * Time.deltaTime);
	}
}
