using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int speed;
	public int score;
	public int hp;
	public Obstacle obstacle;
	public ScreenShake screenshake;
	public GameObject playerscorepart;
	public Image addscoreimg;
	private bool canpoint;
	// Use this for initialization
	void Start () {
		canpoint = false;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D raycastup = Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y + 1), Vector2.up);
		RaycastHit2D raycastdown = Physics2D.Raycast (new Vector2(transform.position.x, transform.position.y - 1), Vector2.down);
		if (raycastup && canpoint) {
			OnCollision ();
		}

		if (raycastdown && canpoint) {
			OnCollision ();
		}

		if (!raycastdown && !raycastup) {
			canpoint = true;
		}

		if (hp <= 0) {
			Debug.Log ("Dead");
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag != "Bullet") {
			hp--;
			StartCoroutine (screenshake.Shake (0.5f, 0.2f));
			Destroy (col.gameObject);
		}
	}

	void OnCollision(){
		score++;
		canpoint = false;
		Instantiate (playerscorepart, transform.position, Quaternion.identity);
		addscoreimg.GetComponent<AddScorePicture> ().OnPointGain (true);
		StartCoroutine (screenshake.Shake (0.1f, 0.1f));
	}
}
