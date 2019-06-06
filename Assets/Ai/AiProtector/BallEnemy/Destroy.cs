using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private HealthContorller health;
       
    void Start()
    {

        Destroy(gameObject, 3f);
        health = PlayerManager.instance.healthBar;
        
    }

    void Update()
    {
        
    }

    // Find Trigger on Collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            health.TakeDamge(10);  
            
        }
    }
}
