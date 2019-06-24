using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour

{
    Transform target;
    public HealthEnamyContorller healthEnamyContorller;

    void Start()
    {
        target = GameManager.instance.main.transform;
        
       
    }


    public void Damage(int damageAmount)
    {

        healthEnamyContorller.heathShield -= damageAmount;
       

        if (healthEnamyContorller.heathShield <= 0)
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
           

        }

       


    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missle")
        {

            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }


    }
}
