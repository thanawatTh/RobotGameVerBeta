using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnamyContorller : MonoBehaviour
{
    //boomber
    public float healthBoomber = 1;
    public GameObject boomber;
    public float starHealthBoomber;


    //protecter
    public float healthProtecter = 3;
    public GameObject protecter;
    public float starHealthProtecter;

    //tank
    public float healthTank = 3;
    public GameObject tank;
    public float starHealthTank;

    //manS
    public float healthManS = 1;
    public GameObject manS;
    public float starHealthManS;

    //SwordN
    public float healthSwordN = 20;
    public GameObject SwordN;
    public float starHealthSwordN;

    //SwordG
    public float heathSwordG = 15;
    public GameObject SwordG;
    public float starHealthSwordG;

    //ShieldEnemy
    public float heathShield = 5;
    public GameObject ShieldEnemy;
    public float starHeathShield;

    //BossEvilEye
    public float healthEvilEye = 65;
    public GameObject evilEye;
    public float starHealthEvilEye;

    //EyeOfEvil
    public float healthEyeOfEvil01 = 50;
    public GameObject eyeOfevil01;
    public float starHeathEyeOfEvil01;

    //public float healthEyeOfEvil02 = 50;
    //public GameObject eyeOfevil02;
    //public float starHeathEyeOfEvil02;

    //public float healthEyeOfEvil03 = 50;
    //public GameObject eyeOfevil03;
    //public float starHeathEyeOfEvil03;

    //public float healthEyeOfEvil04 = 50;
    //public GameObject eyeOfevil04;
    //public float starHeathEyeOfEvil04;

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
