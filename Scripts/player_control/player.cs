using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    //palyer_controller
    private Animator anim;
    private float pSpeed;

    private float pDirection;

    //public GameObject gameob;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        pSpeed = Input.GetAxis("Vertical");

        pDirection = Input.GetAxis("Horizontal");

        anim.SetFloat("speed", pSpeed);
        anim.SetFloat("direction", pDirection);


        anim.SetFloat("speed", pSpeed);


        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("action");
        }
    }
  
}
