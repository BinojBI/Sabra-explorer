using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distructable : MonoBehaviour {

	// Use this for initialization
	public GameObject distructableditem;

	private void OnMouseDown() {
		Instantiate(distructableditem, transform.position, transform.rotation);	
	}
}
