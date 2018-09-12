using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    //palyer_controller
    private Animator anim;
    private float pSpeed;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        pSpeed = Input.GetAxis("Vertical");
        anim.SetFloat("speed", pSpeed);
	}
}
