using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcollider : MonoBehaviour {
	public bool ballentered = false;
	// Use this for initialization


	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("ball"))
		{
			ballentered = true;
			
		}
		
	}

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag("ball"))
		{
			ballentered = false;
			
		}
	}
}
