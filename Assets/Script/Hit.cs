using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    private HealthContorller health;

    void Start()
    {
        health = GameManager.instance.healthBar;
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.tag == "Player")
        {

          health.TakeDamge(20);

        }
        
    }
}
