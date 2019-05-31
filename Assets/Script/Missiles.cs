using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missiles : MonoBehaviour
{
    public Rigidbody missilPrefab;
    public Transform barrelEnd;
    public int countMissiles = 5;
    public Text countM;
    public bool isMissleGo;
    public SkillCoolDown useScript;
    // Start is called before the first frame update
    void Start()
    {
        isMissleGo = false;
    }

    // Update is called once per frame
    void Update()
    {

       if (countMissiles > 0)
       {
            if (Input.GetKeyDown(KeyCode.Alpha1)) 
            {
                    MissleMove();
                    countMissiles--;

                    isMissleGo = true;

            }
            else
            {
                isMissleGo = false;
            }
           
           // countM.text = countMissiles.ToString();
       }
    }
      
    

    void MissleMove()
    {
        Rigidbody missleInstance;
        missleInstance = Instantiate(missilPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        missleInstance.AddForce(barrelEnd.forward * 5000);
    }

   
}
