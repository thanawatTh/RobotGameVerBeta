using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnamyContorller : MonoBehaviour
{
    //boomber
    public float healthBoomber = 1;
    public GameObject boomber;


    //protecter
    public float healthProtecter = 3;
    public GameObject protecter;

    //tank
    public float healthTank = 3;
    public GameObject tank;

    //manS
    public float healthManS = 1;
    public GameObject manS;

    //BossEvilEye
    //public float healthEvilEye = 65;
    //public GameObject evilEye;
    //public Image healthBarBoos;
    //public float starHealthBoss;

    //EyeOfEvil
    public float healthEyeOfEvil01 = 50;
    public GameObject eyeOfevil01;

    public float healthEyeOfEvil02 = 50;
    public GameObject eyeOfevil02;

    public float healthEyeOfEvil03 = 50;
    public GameObject eyeOfevil03;

    public float healthEyeOfEvil04 = 50;
    public GameObject eyeOfevil04;


  


    [Header("Unity Setup")]
    public ParticleSystem deathEffect;


    // Start is called before the first frame update
    void Start()
    {
        //starHealthBoss = healthEvilEye;
    }

    // Update is called once per frame
    void Update()
    {
       

    }


    //public void TakeDamageBoomber(int damage)
    //{

    //    healthBoomber -= damage;

    //}


    //public void TakeDamageProtecter(int damage)
    //{

    //    healthProtecter -= damage;

    //}

    //public void TakeDamageTank(int damage)
    //{

    //    healthTank -=damage;

    //}


    //public void TakeDamageManS(int damage)
    //{
    //    healthManS -= damage;

    //}

    //public void TakeDamage(int damge)
    //{
    //    healthEvilEye = healthEvilEye - damge;
    //    healthBarBoos.fillAmount = healthEvilEye / starHealthBoss;
    //}


}
