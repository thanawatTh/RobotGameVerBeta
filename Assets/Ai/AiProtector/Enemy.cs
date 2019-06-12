using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    public float lookRaius = 5f;

    Transform target;
    NavMeshAgent agent;
    public float speed;

    public Rigidbody missilPrefab;
    public Transform barrelEnd;
    public float fireRate = 0.25f;

    private float nextFire;

    public int currentHealth = 3;

    void Start()
    {

        target = PlayerManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();

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
