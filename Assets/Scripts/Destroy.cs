using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public float destroytime;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroytime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
