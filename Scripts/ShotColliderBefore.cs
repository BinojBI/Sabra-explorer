using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotColliderBefore : MonoBehaviour {
	public bool ballenteredBefore = false;
	public bool shotDefenceBefore = false;
	public bool shotRightBefore = false;
	public bool lossTheBaleBefore;
	public bool shotLeftBefore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

		private void OnTriggerStay(Collider other) {
		if (other.gameObject.CompareTag("ball"))
		{
			ballenteredBefore = true;
			
		}
		
	}

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag("ball"))
		{
			ballenteredBefore = false;
			
		}
	}
}
