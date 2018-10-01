using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    //palyer_controller
    private Animator anim;
    private float pSpeed;
    private float pDirection;
    public GameObject wbox;
    public GameObject door;
    public bool activateTrigger;
    public GameObject RightHand;
    public GameObject item;
    private bool pickedUp;
   
    
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        activateTrigger = false;
        pickedUp = false;
        
       
    }
	
	// Update is called once per frame
	void Update () {
        pSpeed = Input.GetAxis("Vertical");
        pDirection = Input.GetAxis("Horizontal");

        anim.SetFloat("speed", pSpeed);
        anim.SetFloat("direction", pDirection);
      

        if (activateTrigger == false && Input.GetKeyDown(KeyCode.E)&&door.tag == "door")
        {
            anim.SetTrigger("action");
        }
        if (activateTrigger == true && Input.GetKeyDown(KeyCode.E)&& wbox.tag == "wbox")
        {
            anim.SetTrigger("grab");
            
        }
        if(Input.GetKeyDown(KeyCode.E) && pickedUp == true)
        {
            dropItem();
          
        }
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "wbox") {

            pickupItem();
        }
       
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wbox")
        {
            activateTrigger = true;
          

        }
           
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "wbox")
        {
            activateTrigger = false;
           

        }

    }

    public void pickupItem()
    {
        
        if (itemH.handTrigger == true)
        {
            item.transform.parent = RightHand.transform;
            item.transform.localPosition = new Vector3(0.216f, 0.06f, 0.001f);
            item.transform.eulerAngles = new Vector3(85.257f, -32.029f, -122.132f);
            pickedUp = true;
        }
        
        
    }
    public void dropItem()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            item.transform.parent = null;
            item.transform
        }
    }
}
