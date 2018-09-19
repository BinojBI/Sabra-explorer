using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public float distanceAway;
    public float distanceUP;
    public float smooth;

    private Transform follow;
    private Vector3 targetPosition;

	// Use this for initialization
	void Start () {
        follow = GameObject.FindGameObjectWithTag("CamTarget").transform;
	}
	
	void LateUpdate()
    {
        targetPosition = follow.position + follow.up * distanceUP - follow.forward * distanceAway;

        transform.position = Vector3.Lerp(transform.position, targetPosition,  smooth * Time.deltaTime);

        transform.LookAt(follow);
       
    }
}
