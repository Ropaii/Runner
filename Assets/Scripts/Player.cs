using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int speed;
	public int score;
	public int hp;
	public Obstacle obstacle;
	public ScreenShake screenshake;
	public GameObject playerscorepart;
	private RaycastHit2D raycastup;
	private RaycastHit2D raycastdown;
	private bool canpoint;
	// Use this for initialization
	void Start () {
		canpoint = false;
	}
	
	// Update is called once per frame
	void Update () {
		raycastup = Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y + 1), Vector2.up);
		raycastdown = Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y - 1), Vector2.down);
		if (raycastup && canpoint) {
			score++;
			canpoint = false;
			Instantiate (playerscorepart, transform.position, Quaternion.identity);
			StartCoroutine (screenshake.Shake (0.2f, 0.1f));
		}

		if (raycastdown && canpoint) {
			score++;
			canpoint = false;
			Instantiate (playerscorepart, transform.position, Quaternion.identity);
			StartCoroutine (screenshake.Shake (0.2f, 0.1f));
		}

		if (!raycastdown && !raycastup) {
			canpoint = true;
		}

		if (hp <= 0) {
			Debug.Log ("Dead");
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		hp--;
		StartCoroutine(screenshake.Shake (0.5f, 0.2f));
		Destroy (col.gameObject);
	}
}
