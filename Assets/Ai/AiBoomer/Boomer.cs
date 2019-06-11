﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Boomer : MonoBehaviour
{

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    public float lookRaius = 5f;
    public float lookIn = 2f;
  //public float speed;
    
    public NavMeshAgent agent;

    public GameObject booMer;
    public ParticleSystem booM;

    public Transform target;

    private HealthContorller health;

    public int currentHealth = 1;

    void Start()
    {
        target = PlayerManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = PlayerManager.instance.healthBar;
    }
    
    void Update()
    {
        
        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);
        if( distance <= lookRaius)
        {
            agent.SetDestination(target.position);
        }

        if (distance <= lookIn)
        {           
            Instantiate(booM, transform.position, Quaternion.identity);
            health.TakeDamge(90);
            Destroy(booMer);       
        }

    }

    public void Damage(int damageAmount)
    {

        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missle")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
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
