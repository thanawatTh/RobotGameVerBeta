using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1ball : MonoBehaviour
{

    [Header("Unity Setup")]
    public ParticleSystem deathEffect;

    public int currentHealth = 1;
    Rigidbody rb;
    

    public float cudeSize = 0.2f;
    public int cubeInrow = 5;

    private Animator anim;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        

    }


    public void Damage(int damageAmount)
    {

        currentHealth -= damageAmount;
        anim.Play("Hit" ,0 ,0);
        
        



        if (currentHealth <= 0)
        {
            //Instantiate(deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);

        }



    }
}
