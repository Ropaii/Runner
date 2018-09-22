using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private int yincrement;
	private int maxheight;
	private int minheight;
	private Vector2 targetpos;
	private Player player;
	// Use this for initialization
	void Start () {
		yincrement = 3;
		maxheight = 3;
		minheight = -3;
		player = GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, targetpos, player.speed * Time.deltaTime);
		Vector3 transpos = transform.position;
		transpos.y = Mathf.Clamp (transform.position.y, minheight, maxheight);
		transform.position = transpos;

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			targetpos = new Vector2(transform.position.x,transform.position.y + yincrement);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			targetpos = new Vector2(transform.position.x,transform.position.y - yincrement);
		}
	}
}
