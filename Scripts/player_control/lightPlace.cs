using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class lightPlace : MonoBehaviour
{
    public GameObject text_startGame;
    public GameObject point_table;
    public GameObject addpoints;
    public GameObject winText;
    public int x;
    public bool wincheck = false;

    public GameObject[] coin;




    // Use this for initialization
    void Start()
    {
        text_startGame.SetActive(false);
        point_table.SetActive(false);
        addpoints.SetActive(false);
        winText.SetActive(false);
        for (x = 0; x < 5; x++)
        {
            coin[x].SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (points.display() == 1)
        {
           
            if (wincheck == false)
            {
                Win();
                wincheck = true;
            }
            
        }
        }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            text_startGame.SetActive(true);


        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text_startGame.SetActive(false);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            point_table.SetActive(true);
            addpoints.SetActive(true);
            for (x = 0; x < 5; x++)
            {
                coin[x].SetActive(true);
            }

            //Instantiate(coin1, new Vector3(2.16F, 0.59f, 3.33f), Quaternion.identity);
            //Instantiate(coin1, new Vector3(5F, 0.59f, 3.33f), Quaternion.identity);
        }
    }

        public  void Win(){
            Debug.Log("you win");
            winText.SetActive(true);
            Destroy(winText, 3f);

    }
       
    
    
}
