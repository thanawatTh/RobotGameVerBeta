using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnamyContorller : MonoBehaviour
{
    //boomber
    public float healthBoomber = 1;
    public GameObject boomber;


    //protecter
    public float healthProtecter = 3;
    public GameObject protecter;

    //tank
    public float healthTank = 3;
    public GameObject tank;

    //manS
    public float healthManS = 1;
    public GameObject manS;

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


    }


    public void TakeDamageBoomber(int damage)
    {

        healthBoomber -= damage;
        
    }


    public void TakeDamageProtecter(int damage)
    {

        healthProtecter -= damage;
        
    }

    public void TakeDamageTank(int damage)
    {

        healthTank -=damage;

    }


    public void TakeDamageManS(int damage)
    {
        healthManS -= damage;

    }


}
