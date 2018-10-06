using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetGen : MonoBehaviour {

	// Use this for initialization
 public GameObject targets;
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 3; i++)
		{
			Instantiate(targets, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		}
	}
}
