﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{

    [Header("Unity Setup")]
    
    Rigidbody rb;
    public float lookRaius = 5f;
    public float lookIn = 2f;

    public Transform target;

    private HealthContorller health;

    public NavMeshAgent agent;

    private float nextFire;

    public Animator animator;
 
    public Image hpBarPosition;
    public Image hpBar;
    public HealthEnamyContorller healthEnamyContorller;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
        healthEnamyContorller.starHealthSwordN = healthEnamyContorller.healthSwordN;
        hpBarPosition.enabled = true;
        hpBar.enabled = true;
    }

    void Update()
    {     
        float distance = Vector3.Distance(target.position, transform.position);

        agent.SetDestination(target.position);

        if (distance <= lookIn && Time.time > nextFire)
        {
            animator.SetFloat("Hit", lookIn);
        }

    }

    public void Damage(int damageAmount)
    {

        healthEnamyContorller.healthSwordN -= damageAmount;
        hpBar.fillAmount = healthEnamyContorller.healthSwordN / healthEnamyContorller.starHealthSwordN;

        if (healthEnamyContorller.healthSwordN <= 0)
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
            hpBarPosition.enabled = false;
            hpBar.enabled = false;

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Missle")
            {

                Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                hpBarPosition.enabled = false;
                hpBar.enabled = false;
            }


        }

    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookIn);

    }

}
