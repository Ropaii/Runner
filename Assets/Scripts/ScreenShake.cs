using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator Shake(float duration, float force){
		Vector3 orgpos = transform.localPosition;
		float elapsed = 0f;

		while (elapsed < duration) {
			float x = Random.Range (-1f, 1f) * force;
			float y = Random.Range (-1f, 1f) * force;

			transform.localPosition = new Vector3 (x, y, orgpos.z);
			elapsed += Time.deltaTime;

			yield return null;
		}

		transform.localPosition = orgpos;
	}
}
