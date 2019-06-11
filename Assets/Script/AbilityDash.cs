﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDash : MonoBehaviour
{
    
    public float distace = 5.0f;
    private Rigidbody rigiBody;
    public float fireRate = 0.25f;
    private float nextFire;
    public bool dashStart;
    public bool isDashGo;
    
    // Start is called before the first frame update

     void Start()
    {
        rigiBody = GetComponent<Rigidbody>();
        
       
    }
    // Update is called once per frame
    void Update()
    {

       /* if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)  
            {
                nextFire = Time.time + fireRate;
            Debug.Log(nextFire);
                DashForward();
            }*/

///////////////////////////////////////////////////////////////////////////////
///
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Debug.Log(nextFire);
            DashForward();
        }*/




        if(dashStart == true)
        {
            isDashGo = true;
            DashForward();
        }


    }

    public void DashForward()
    {
        RaycastHit hit;
        Vector3 destination = transform.position + transform.forward * distace ;


        //hit block
        if (Physics.Linecast(transform.position , destination, out hit)) 
        {
            destination = transform.position + transform.forward * (hit.distance - 1f);
            dashStart = true;
        }


       //not hit block
       if (Physics.Raycast(destination, -Vector3.up, out hit))
        {
            destination = hit.point;
            destination.y = 1f;
            transform.position = destination;
            dashStart = true;
        }
        

    }


    public void onTouchDown()
    {
        dashStart = true;
    }


    IEnumerator waitSpeed()
    {
        yield return new WaitForSeconds(1);

    }

    public void onTouchUp()
    {
        dashStart = false;
        StartCoroutine(waitSpeed());
    }









}
