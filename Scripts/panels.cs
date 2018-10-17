using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panels : MonoBehaviour {
    public GameObject uiObject;
    public Animator anim;

	// Use this for initialization
	void Start () {
        uiObject.SetActive(false);
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("openGate");
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            
           
            
        }

    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(false);
        }
            
    }


}
