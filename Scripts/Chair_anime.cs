﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair_anime : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("Action");
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            anim.Play("Down");
        }
    }
}
