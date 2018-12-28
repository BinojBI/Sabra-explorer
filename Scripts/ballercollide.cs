using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballercollide : MonoBehaviour {
public bool ballered = false;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
			if(other.gameObject.CompareTag("Player")){
			ballered = true;

	}
		}

			 void OnTriggerExit(Collider other) {
			if(other.gameObject.CompareTag("Player")){
			ballered = false;
		}
}
}
