﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera1 : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            anim.SetBool("isMove",true);
            Debug.Log("movecamera");
        }
    }
   
}
