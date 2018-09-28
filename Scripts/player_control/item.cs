using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
    public Vector3 pickupPosition;
    public Vector3 pickupRotation;
    public bool settrig;
   
	// Use this for initialization
	void Start () {
        settrig = false;
    }
	
	// Update is called once per frame
	public void FixedUpdate() {
        if (settrig == true)
        {
            transform.position = pickupPosition;
        }
        
        //gameObject.transform.eulerAngles = pickupRotation;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            settrig = true;
        }
    }
}
