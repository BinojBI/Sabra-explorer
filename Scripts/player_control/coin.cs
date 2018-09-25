using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour {

    public Text guitxt;

    // Use this for initialization
    void Start () {
        SetCount();
	}
	
	// Update is called once per frame
	void Update () {
      
            }

    void OnTriggerEnter(Collider col) //If you exit the trigger this will happen.
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            points.coinCollect();
            Debug.Log(points.display());
            SetCount();

        }

    }

    void SetCount()
    {
         guitxt.text = " : " + points.display();
  
    }
}
