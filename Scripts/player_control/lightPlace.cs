using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class lightPlace : MonoBehaviour
    {
        public GameObject text_startGame;
        public GameObject point_table;
        public GameObject coin1;
        


    // Use this for initialization
    void Start()
        {
            text_startGame.SetActive(false);
            point_table.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {
        
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
           
            
                Instantiate(coin1, new Vector3(2.16F, 0.59f, 3.33f), Quaternion.identity);
                Instantiate(coin1, new Vector3(5F, 0.59f, 3.33f), Quaternion.identity);
        }
        }
    
}
