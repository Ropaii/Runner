using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] ObstaclePatterns;
	private float spawntime;
	private float difftime;
	private float maxtime;
	// Use this for initialization
	void Start () {
		spawntime = 300f;
		maxtime = spawntime / 1.2f ;
		//Instantiate (ObstaclePatterns[0],transform.position,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		spawntime--;
		if (spawntime <= 0f) {
			int rand = Random.Range (0, ObstaclePatterns.Length);
			Instantiate(ObstaclePatterns[rand], transform.position, Quaternion.identity);
			difftime += 10f;
			difftime = Mathf.Clamp (difftime, 0f, maxtime);
			spawntime = 300f - difftime;
		}
	}
}
