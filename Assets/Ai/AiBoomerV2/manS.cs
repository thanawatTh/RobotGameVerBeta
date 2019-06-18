using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manS : MonoBehaviour
{

    //[Header("Unity Setup")]
    //public ParticleSystem deathEffect;

    public float lookRaius = 5f;
    public float lookIn = 2f;
    public float speed = 5f;

    public UnityEngine.AI.NavMeshAgent agent;

    public GameObject booMer;
    public ParticleSystem booM;

    public Transform target;

    private HealthContorller health;

    public int currentHealth = 1;

    private float nextFire;

    public float fireRate = 2f;


    private HealthEnamyContorller healthEnamyContorller;

    void Start()
    {
        target = GameManager.instance.main.transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        health = GameManager.instance.healthBar;
        healthEnamyContorller = GameObject.Find("Gamemanager").GetComponent<HealthEnamyContorller>();

}

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);
        


        if (distance <= lookRaius)
        {
            
            agent.SetDestination(target.position);
        }

        if (distance <= lookIn)
        {
            Instantiate(booM, transform.position, Quaternion.identity);
            health.TakeDamge(5);
            Destroy(booMer);
        }

    }

    public void Damage(int damageAmount)
    {

        healthEnamyContorller.healthManS -= damageAmount;

        if (healthEnamyContorller.healthManS <= 0)
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missle")
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
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
