using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
    public GameObject uiObjectt;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObjectt.SetActive(true);

        }



    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObjectt.SetActive(false);
        }

    }
}
