using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

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
    //public Image hpBarPosition;
    //public Image hpBar;
    


    //public int currentHealth = 3;

    void Start()
    {

        target = GameManager.instance.main.transform;
        healthEnamyContorller = GameManager.instance.GetComponent<HealthEnamyContorller>();
        agent = GetComponent<NavMeshAgent>();
        healthEnamyContorller.starHealthProtecter = healthEnamyContorller.healthProtecter;
        //hpBarPosition.enabled = true;
        //hpBar.enabled = true;
       
        
    }

    public void Damage(int damageAmount)
    {
        healthEnamyContorller.healthProtecter -= damageAmount;

        //hpBar.fillAmount = healthEnamyContorller.healthProtecter / healthEnamyContorller.starHealthProtecter;

        if (healthEnamyContorller.healthProtecter <= 0)
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
    }

    void Update()
    {
        //hpBarPosition.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 5f, 0));

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
