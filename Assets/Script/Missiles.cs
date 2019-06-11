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
    public bool missleCall;


    

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
        if (missleCall == true)
        {
            MissleMove();
            isMissleGo = true;

            

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
       
       missleCall = true;

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        //missleCall = true;
    }

   

   

    public void OnTouchUp()
    {
        
        missleCall = false;
        StartCoroutine(wait());
    }




}

