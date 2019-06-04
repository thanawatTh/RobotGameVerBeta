using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missiles : MonoBehaviour
{
    public Rigidbody missilPrefab;
    public Transform barrelEnd;
    public int countMissiles;
    public Text countM;
    public bool isMissleGo;


    

    // Start is called before the first frame update
    void Start()
    {
        isMissleGo = false;
    }

    // Update is called once per frame
    void Update()
    {
       
       if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MissleMove();
            //countMissiles--;

            isMissleGo = true;

        }
        
            
    }
    

    void MissleMove()

    {
       if (!isMissleGo)

       {
            Rigidbody missleInstance;
            missleInstance = Instantiate(missilPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            missleInstance.AddForce(barrelEnd.forward * 5000);
       }
       
        
    }
  

}

