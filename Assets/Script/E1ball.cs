using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class E1ball : MonoBehaviour
{

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    public int currentHealth = 1;
    Rigidbody rb;
    public float lookRaius = 5f;
    public float lookIn = 2f;
    public float distace = 5.0f;

    public Transform target;

    private HealthContorller health;

    public GameObject Ball;
    public ParticleSystem ballHit;

    public float cudeSize = 0.2f;
    public int cubeInrow = 5;

    private Animator anim;

    public NavMeshAgent agent;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
    }

    void Update()
    {
        
      
        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);

        if (distance <= lookRaius)
        {
            Vector3 destination = target.position + transform.forward * distace;
            transform.position = destination;
        }

        if (distance <= lookIn)
        {
            Instantiate(ballHit, transform.position, Quaternion.identity);
            health.TakeDamge(20);
            Destroy(Ball);
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

