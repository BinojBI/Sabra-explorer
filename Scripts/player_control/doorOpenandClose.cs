/*/Script made by Strups Productions/*/
using UnityEngine;
using System.Collections;

public class doorOpenandClose : MonoBehaviour {

	//Text variables
	public bool T_ActivatedOpen = true;
	public bool T_ActivatedClose = false;
	public bool activateTrigger = false;
    
    

	public GameObject textO;
	public GameObject textC;

	//Animator variables
	Animator animator;
	bool doorOpen =false;
	//Sound variables
	//public GameObject doorOpenSound;
	//public GameObject doorCloseSound;






	void Start () { //what happens in the beginning of the game.
		textC.SetActive (false);
		textO.SetActive (false);
		T_ActivatedOpen = true;
		T_ActivatedClose = false;

		animator = GetComponent<Animator> ();
		doorOpen = false;


		//doorCloseSound.SetActive (false);
		//doorOpenSound.SetActive (false);



	
	}


    void Update()
    { //The main function wich controlls how the system will work.

        if ((activateTrigger && Input.GetKeyDown(KeyCode.E))&& !this.doorOpen) {
            Debug.Log("loaded");
            this.doorOpen = true;
            doorController("Open");
            textO.SetActive(false);
            textC.SetActive(true);
          

        }
        else if ((activateTrigger && Input.GetKeyDown(KeyCode.E))&&this.doorOpen) {
            Debug.Log("Loaded2");
            this.doorOpen = false;
            doorController("Close");
            textO.SetActive(true);
            textC.SetActive(false);

        }
    }

		//if (T_ActivatedOpen == true) {
  //          T_ActivatedClose = false;
  //      }
			

		//else if (T_ActivatedClose == true)
  //      {
  //          T_ActivatedOpen = false;
  //      }

      

		//if ((activateTrigger && Input.GetKeyDown (KeyCode.E)) && (!this.doorActivated)) //For some reaseon you can't have both E (open and close).
		//	{
		//		textO.SetActive (false);
		//		textC.SetActive (false);
		//		T_ActivatedOpen = false;
		//		T_ActivatedClose = true;
		//		textO.SetActive (false);
		//		textC.SetActive (true);
		//		doorOpen = true;
  //              open = true;
            //this.doorActivated = true;
            //doorOpenSound.SetActive (true);
            //doorCloseSound.SetActive (false);
   //         Debug.Log("the dorr is open");

			//if (doorOpen) 
			//{
			//	doorOpen = true;
			//	doorController ("Open");
			//}
				
			//}

		 //   else if((T_ActivatedClose && activateTrigger && Input.GetKey (KeyCode.E)) && (this.doorActivated)) 
			//{
			//	T_ActivatedOpen = true;
			//	T_ActivatedClose = false;
			//	textO.SetActive (true);
			//	textC.SetActive (false);
   //             this.doorActivated = false;
   //         Debug.Log("the dorr is closed");
            //doorCloseSound.SetActive (true);
            //doorOpenSound.SetActive (false);

   //         if (doorOpen) 
			//{
			//	doorOpen = false;
			//	doorController ("Close");
			//}
				
			//} 
	


														
	void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{

				activateTrigger = true;
			if((T_ActivatedOpen == true))
            {
                textO.SetActive(true);
                
            }


            if ((T_ActivatedClose == true)) {
                textC.SetActive(true);
               
            }
				
		}
		
	}


	void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
			textO.SetActive (false);
			textC.SetActive (false);
			activateTrigger = true;
		}

	}

	void doorController(string direction) //Animator function.
	{
		animator.SetTrigger(direction);
	}
		
}
