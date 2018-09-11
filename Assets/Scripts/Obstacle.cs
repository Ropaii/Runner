using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	public float speed;
	public GameObject effect;
	private ScreenShake screenshake;
	// Use this for initialization
	void Start () {
		screenshake = Camera.main.GetComponent<ScreenShake> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Bullet") {
			StartCoroutine(screenshake.Shake(0.5f,0.2f));
			Destroy (gameObject);
		} else {
			Instantiate (effect, transform.position, Quaternion.identity);
		}
	}
}
