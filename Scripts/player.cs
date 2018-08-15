using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    private Animator anim;
    public float playerSpeed;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        playerSpeed = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", playerSpeed);

        float mouseInput = Input.GetAxis("Mouse X");
        
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        
        transform.Rotate(lookhere);
        

    }
}
