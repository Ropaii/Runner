using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScorePicture : MonoBehaviour {
	private int activetimer = 60;
	void Update(){
		activetimer--;
		if (activetimer <= 0) {
			gameObject.SetActive (false);
			activetimer = 15;
		}
	}
	public void OnPointGain(bool isactive){
		gameObject.SetActive (isactive);
	}
}
