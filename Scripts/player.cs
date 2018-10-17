using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    private Animator anim;
    private float playerSpeed;
    private float playerSide;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        playerSpeed = Input.GetAxis("Vertical");
        playerSide = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", playerSpeed);
        anim.SetFloat("side", playerSide);



    }
 
  
}
