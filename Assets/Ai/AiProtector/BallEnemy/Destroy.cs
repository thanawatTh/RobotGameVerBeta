using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private HealthContorller health;
    bool notDamage = false;
       
    void Start()
    {

        Destroy(gameObject, 3f);
        health = GameManager.instance.healthBar;
        notDamage = false;
    }

    void Update()
    {
        
    }

    // Find Trigger on Collider
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

                health.TakeDamge(10);

            }
        }

    }

    
}
