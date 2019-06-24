using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EyeOfEvilL : MonoBehaviour
{

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    public int currentHealth = 1;
    Rigidbody rb;

    public float lookRaius = 5f;
    
    public Transform target;

    private HealthContorller health;

    public GameObject Ball;
    public ParticleSystem ballHit;

    public NavMeshAgent agent;

    private float nextFire;

    public float fireRate = 2f;
    
    public Rigidbody missilPrefab;
    public Transform barrelEnd;
    public Image hpBarPosition;
    public Image hpBar;
    public HealthEnamyContorller healthEnamyContorller;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
       
    }

    void Update()
    {
       
        Vector3 targetPosition = new Vector3
            (target.transform.position.x, transform.transform.position.y, target.transform.position.z);
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRaius && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody missleInstance;
            missleInstance = Instantiate(missilPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            missleInstance.AddForce(barrelEnd.forward * 2000);

            transform.LookAt(targetPosition);
        }
     
    }

    public void Damage(int damageAmount)
    {

        healthEnamyContorller.healthEyeOfEvil01 -= damageAmount;
        //hpBar.fillAmount = healthEnamyContorller.healthEyeOfEvil01 / healthEnamyContorller.starHeathEyeOfEvil01;
        //currentHealth -= damageAmount;

        if (healthEnamyContorller.healthEyeOfEvil01 <= 0)
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
       
    }

}
