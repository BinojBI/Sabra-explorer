using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WicketCollider : MonoBehaviour {
public bool wicketed = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("ball")){
		wicketed = true;
	}
	}

	private void OnTriggerExit(Collider other) {
		if(other.gameObject.CompareTag("ball")){
		wicketed = false;
	}
	}
}

