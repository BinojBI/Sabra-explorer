using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCharacter : MonoBehaviour {
    public float Gravity=20f;
    public bool UseGravity= true;
    private CharacterController characterController;
	// Use this for initialization
	void Awake () {
        characterController = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!characterController.isGrounded && UseGravity)
        {
            characterController.SimpleMove(gameObject.transform.up * Gravity * Time.deltaTime);
        }
    }
}
