using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    private HealthContorller health;
    bool notDamage = false;

    void Start()
    {
        health = GameManager.instance.healthBar;
       notDamage = false;
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShieldTag")
        {
            health.TakeDamge(0);
            notDamage = true;
        }

        if (!notDamage)
        {
            if (other.gameObject.tag == "Player")
            {

                health.TakeDamge(20);

            }

        }


        
        
    }
}
