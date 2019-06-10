using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Missiles : MonoBehaviour
{
    public Rigidbody missilPrefab;
    public Transform barrelEnd;
    public int countMissiles;
   // public Text countM;
    public bool isMissleGo;
    public bool MissleCall;


    

    // Start is called before the first frame update
    void Start()
    {
        isMissleGo = false;

       
    }

    // Update is called once per frame
    void Update()
    {
        ///Mouse 0
        ///////////////////////////////////////////////////////////////////////////////////////
        /*  if (Input.GetKeyDown(KeyCode.Alpha1))
           {
               MissleMove();
               //countMissiles--;

               isMissleGo = true;

           }*/

        //TouchSkill
        ///////////////////////////////////////////////////////////////////////////////////////
        if (MissleCall == true)
        {
            MissleMove();
            isMissleGo = true;
        }

        if (MissleCall == false)
        {
            isMissleGo = false;
        }

       
        
            
    }
    

    public void MissleMove()

    {
       if (!isMissleGo)

       {
            Rigidbody missleInstance;
            missleInstance = Instantiate(missilPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            missleInstance.AddForce(barrelEnd.forward * 5000);

        }
       
        
    }

    public void OnTouchDown()
    {
        MissleCall = true;
    }

    public void OnTouchUp()
    {
        MissleCall = false;
    }




}

