using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour {
    //palyer_controller
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject man;
    private Animator anim;
   
    
   
    // Use this for initialization
    void Start()
    {
       uiObject.SetActive(false);
        //anim.SetBool("open_gate", false);
        anim = GetComponent<Animator>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (uiObject.active == true && Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("open_gate");
            uiObject.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
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
