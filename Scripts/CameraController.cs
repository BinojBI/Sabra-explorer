using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private const float Y_ANGLE_MIN = -50.0f;
    private const float Y_ANGLE_MAX = 50.0f;
    public Transform lookAt;
    public Transform camTransform;
    
   

    private Camera cam;

    private float distance = 2.5f;
    private float currentX = 0.1f;
    private float currentY = 5.09f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 8.0f;


    // Use this for initialization
    void Start()
    {
        //rb.position = pos;

        camTransform = transform;
        cam = Camera.main;
    }

    void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY -= Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }
       
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 dir = new Vector3(0,3f,-distance);
        Quaternion rotation = Quaternion.Euler(currentY,currentX,0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);

    }
}
