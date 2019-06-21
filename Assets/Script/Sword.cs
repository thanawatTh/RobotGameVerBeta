using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sword : MonoBehaviour
{

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    public int currentHealth = 1;
    Rigidbody rb;
    public float lookRaius = 5f;
    public float lookIn = 2f;

    public Transform target;

    private HealthContorller health;

    public GameObject Ball;
    public ParticleSystem ballHit;

    public NavMeshAgent agent;

    public Transform[] spawnPoints;
    public GameObject[] cube;

    private float nextFire;

    public float fireRate = 2f;
    public float fireRateBoom = 5f;
    public Rigidbody missilPrefab;
    public Transform barrelEnd;

    public HealthEnamyContorller healthEnamyContorller;

    public Animator animator;

    public BossHealth bossHealth;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
        healthEnamyContorller = GameObject.Find("Gamemanager").GetComponent<HealthEnamyContorller>();
    }

    void Update()
    {     
        float distance = Vector3.Distance(target.position, transform.position);
      
        if (distance <= lookRaius && Time.time > nextFire)
        {
            
        }

        if (distance <= lookIn && Time.time > nextFire)
        {
            animator.SetFloat("Hit", lookIn);
        }

    }

    //public void Damage(int damageAmount)
    //{

    //    healthEnamyContorller.healthEvilEye  -= damageAmount;

    //    if (healthEnamyContorller.healthEvilEye <= 0)
    //    {
    //        Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

    //        gameObject.SetActive(false);

    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Missle")
        //{
        //    healthEnamyContorller.healthEvilEye -= 5;
        //    Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

        //    if (healthEnamyContorller.healthEvilEye <= 0)
        //    {
        //        Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

        //        gameObject.SetActive(false);

        //    }

        //}

        if (other.gameObject.tag == "Missle")
        {
            bossHealth.TakeDamage(5);
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            if (bossHealth.healthEvilEye <= 0)
            {
                Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

                gameObject.SetActive(false);

            }

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
