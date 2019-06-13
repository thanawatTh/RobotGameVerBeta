using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnamyContorller : MonoBehaviour
{
    //boomber
    public float healthBoomber = 1;

    //protecter
    public float healthProtecter = 3;

    //tank
    public float healthTank = 3;

    //public float startHealth;

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (healthBoomber <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);

        }

        if (healthTank <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);

        }

        if (healthProtecter <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
        }

    }


    public void TakeDamageBoomber(int damage)
    {

        healthBoomber = healthBoomber - damage;
        
    }


    public void TakeDamageProtecter(int damage)
    {
        healthProtecter = healthProtecter - damage;
        
    }

    public void TakeDamageTank(int damage)
    {


        healthTank = healthTank - damage;


    }


}
