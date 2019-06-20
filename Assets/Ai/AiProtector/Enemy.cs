using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //[Header("Unity Setup")]
    //public ParticleSystem deathEffect;

    public float lookRaius = 5f;

     Transform target;
    NavMeshAgent agent;
    public float speed;

    public Rigidbody missilPrefab;
    public Transform barrelEnd;
    public float fireRate = 0.25f;

    private float nextFire;
    


    private HealthEnamyContorller healthEnamyContorller;

    //public int currentHealth = 3;

    void Start()
    {

        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        healthEnamyContorller = GameObject.Find("Gamemanager").GetComponent<HealthEnamyContorller>();

    }

    public void Damage(int damageAmount)
    {
        healthEnamyContorller.healthProtecter -= damageAmount;

        if (healthEnamyContorller.healthProtecter <= 0)
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

    void Update()
    {
        
        float distance = Vector3.Distance(target.position, transform.position);
        Vector3 targetPosition = new Vector3
            (target.transform.position.x, transform.transform.position.y, target.transform.position.z);

        if (distance <= lookRaius && Time.time > nextFire)
        {

            //agent.SetDestination(target.position);

            nextFire = Time.time + fireRate;

            Rigidbody missleInstance;
            missleInstance = Instantiate(missilPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            missleInstance.AddForce(barrelEnd.forward * 2000);
            Debug.Log("missle");
     
            transform.LookAt(targetPosition);

        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRaius);
    }

}
