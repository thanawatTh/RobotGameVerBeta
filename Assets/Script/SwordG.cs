using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class SwordG : MonoBehaviour
{

    [Header("Unity Setup")]

    Rigidbody rb;
    public float lookRaius = 5f;
    public float lookIn = 2f;

    public Transform target;

    private HealthContorller health;

    public NavMeshAgent agent;

    private float nextFire;
    public HealthEnamyContorller healthEnamyContorller;
    public Image hpBarPosition;
    public Image hpBar;

    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
        healthEnamyContorller.starHealthSwordG = healthEnamyContorller.heathSwordG;
        hpBarPosition.enabled = true;
        hpBar.enabled = true;

    }

    void Update()
    {
        hpBarPosition.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 5f, 0));
        float distance = Vector3.Distance(target.position, transform.position);

        agent.SetDestination(target.position);

        if (distance <= lookIn && Time.time > nextFire)
        {
            animator.SetFloat("HitHam", lookIn);
        }

    }

    public void Damage(int damageAmount)
    {

        healthEnamyContorller.heathSwordG -= damageAmount;
        hpBar.fillAmount = healthEnamyContorller.heathSwordG / healthEnamyContorller.starHealthSwordG;

        if (healthEnamyContorller.heathSwordG <= 0)
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
            hpBarPosition.enabled = false;
            hpBar.enabled = false;

        }

       

    }


    public  void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Missle")
        {
            healthEnamyContorller.heathSwordG -= 5;
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
            //Destroy(gameObject);


            if (healthEnamyContorller.heathSwordG <= 0)
            {
                Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

                gameObject.SetActive(false);
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

