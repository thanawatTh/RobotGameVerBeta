using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBlock : MonoBehaviour
{
    //public HealthContorller health;
    public bool notDamage;
    Boomer boomer;
   
    // Start is caled before the first frame update
    void Start()
    {
        boomer = GameObject.Find("Boomer").GetComponent<Boomer>();
        notDamage = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TestEnamy")
        {
            notDamage = true;
            Debug.Log("Blockkk");
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        notDamage = false;
    }
}
    
