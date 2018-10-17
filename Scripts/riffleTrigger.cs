using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riffleTrigger : MonoBehaviour {
	public GameObject findRiffle;
	public bool setfindriffle= false;
	// Use this for initialization
	void Start () {
		findRiffle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag=="Player"){
			findRiffle.SetActive(true);
			setfindriffle = true;
		}
	}

	private void OnTriggerExit(Collider other) {
		if(other.gameObject.tag=="Player"){
			findRiffle.SetActive(false);
		}
	}
}
