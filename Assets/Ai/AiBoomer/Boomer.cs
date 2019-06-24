﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Boomer : MonoBehaviour
{

    //[Header("Unity Setup")]
    //public ParticleSystem deathEffect;

    public float lookRaius = 5f;
    public float lookIn = 2f;
  //public float speed;
    
    public NavMeshAgent agent;

    public GameObject booMer;
    public ParticleSystem booM;

    public Transform target;

    public HealthContorller health;
   
    public bool boomberDie;
   

    //public int currentHealth = 1;

    private HealthEnamyContorller healthEnamyContorller;
    //public Image hpBarPosition;
    //public Image hpBar;



    void Start()
    {
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
        healthEnamyContorller = GameManager.instance.GetComponent<HealthEnamyContorller>();

        boomberDie = false;
        //hpBarPosition.enabled = true;
        //hpBar.enabled = true;

        healthEnamyContorller = GameManager.instance.GetComponent<HealthEnamyContorller>();

    }

    void Update()
    {
        //hpBarPosition.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 5f, 0));

        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);
        if (distance <= lookRaius)
        {
            agent.SetDestination(target.position);
        }



        if (distance <= lookIn ) 
        {
            if(boomberDie == false)
            {
                Instantiate(booM, transform.position, Quaternion.identity);
                health.TakeDamge(90);
                Destroy(booMer);
                //hpBarPosition.enabled = false;
                //hpBar.enabled = false;
            }
            
                      
                
            

        } 
       
    }
       
    

    public void Damage(int damageAmount)
    {
       
        //currentHealth -= damageAmount;
        healthEnamyContorller.healthBoomber -= damageAmount;

        if (healthEnamyContorller.healthBoomber <= 0) 
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
            //hpBarPosition.enabled = false;
            //hpBar.enabled = false;


        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missle")
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //hpBarPosition.enabled = false;
            //hpBar.enabled = false;

        }

        if (other.gameObject.tag == "ShieldTag")
        {
            boomberDie = true;
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //hpBarPosition.enabled = false;
            //hpBar.enabled = false;

        }
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRaius);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookIn);

    }

}
