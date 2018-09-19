using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
