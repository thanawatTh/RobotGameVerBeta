using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class E1ball : MonoBehaviour
{

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    //public int currentHealth = 1;
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

    bool ballDie = false;
    public AudioSource gunAudio;

    private HealthEnamyContorller healthEnamyContorller;
    //public Image hpBarPosition;
    //public Image hpBar;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        target = GameManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
        health = GameManager.instance.healthBar;
        ballDie = false;
        //hpBarPosition.enabled = true;
        //hpBar.enabled = true;
        healthEnamyContorller = GameManager.instance.GetComponent<HealthEnamyContorller>();
    }

    void Update()
    {

        //hpBarPosition.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 5f, 0));

        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);

        if (distance <= lookRaius)
        {
            Vector3 destination = target.position + transform.forward * distace;
            transform.position = destination;
        }

        if (distance <= lookIn)
        {
            if (ballDie == false)
            {
                Instantiate(ballHit, transform.position, Quaternion.identity);
                health.TakeDamge(20);
                
                Destroy(Ball);
                //hpBarPosition.enabled = false;
                //hpBar.enabled = false;
            }
            gunAudio.Play();

        }

        

    }

    public void Damage(int damageAmount)
    {

        healthEnamyContorller.healthManS -= damageAmount;

        if (healthEnamyContorller.healthManS <= 0)
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

        if (other.gameObject.tag == "ShieldTag")
        {
            ballDie = true;
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //hpBarPosition.enabled = false;
            //hpBar.enabled = false;

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

