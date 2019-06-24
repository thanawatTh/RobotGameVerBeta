using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.UI;

public class BallEnemy : MonoBehaviour
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
    //public Image hpBarPosition;
    //public Image hpBar;
    public Transform positionBall;
    private AudioSource gunAudio;


    //public int currentHealth = 3;

    private HealthEnamyContorller healthEnamyContorller;

    void Start()
    {

        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        //healthEnamyContorller.starHealthTank = healthEnamyContorller.healthTank;
        //hpBarPosition.enabled = true;
        //hpBar.enabled = true;
        healthEnamyContorller = GameManager.instance.GetComponent<HealthEnamyContorller>();
    }


    public void Damage(int damageAmount)
    {

        healthEnamyContorller.healthTank -= damageAmount;
        //hpBar.fillAmount = healthEnamyContorller.healthTank / healthEnamyContorller.starHealthTank;

        if (healthEnamyContorller.healthTank <= 0)
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
            gunAudio.Play();
            Destroy(gameObject);
            //hpBarPosition.enabled = false;
            //hpBar.enabled = false;
        }

       
    }

    void Update()
    {
        //hpBarPosition.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 5f, 0));
       
        //transform.position = Vector3.MoveTowards(transform.position, target.position , speed * Time.deltaTime);
        float distance = Vector3.Distance(target.position, transform.position);
     
        if (distance <= lookRaius && Time.time > nextFire)
        {

            agent.SetDestination(target.position);

            nextFire = Time.time + fireRate;

            Rigidbody missleInstance;
            missleInstance = Instantiate(missilPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            missleInstance.AddForce(barrelEnd.forward * 2000);
            Debug.Log("missle");

        }
   
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRaius);
    }

}
