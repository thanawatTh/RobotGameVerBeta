﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour
{
    //dash
    private Image imageCooldownDash;
    private float cooldownDash = 1;
    public bool isCooldownDash;
    public AbilityDash abilityDash;


    //missle
    private Image imageCooldownMissle;
    private float cooldownMissle = 5;
    public bool isCooldownMissle;
    public Missiles missiles;

    //shield
    public Image imageCooldownShield;
    private float cooldownShield = 20;
    public bool isCooldownShield;
    public ShieldAbility shieldAbility;


    // Start is called before the first frame update
    void Start()
    {
        abilityDash = GameObject.Find("Body").GetComponent<AbilityDash>();
        missiles = GameObject.Find("Body").GetComponent<Missiles>();
        shieldAbility = GameObject.Find("Body").GetComponent<ShieldAbility>();

        imageCooldownDash = GameObject.Find("Speed").GetComponent<Image>();
        imageCooldownMissle = GameObject.Find("CooldownMissle").GetComponent<Image>();
        imageCooldownShield = GameObject.Find("CooldownShield").GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        //dash
        if (abilityDash.isDashGo == true)
        {
            isCooldownDash = true;
        }

        if (isCooldownDash == true)
        {
            imageCooldownDash.fillAmount += 1 / cooldownDash * Time.deltaTime;

            if (imageCooldownDash.fillAmount >= 1)
            {
                imageCooldownDash.fillAmount = 0;
                isCooldownDash = false;
                abilityDash.isDashGo = false;
            }
        }

        //missle

         if (missiles.isMissleGo == true)    
        {
            isCooldownMissle = true;
        }

        if (isCooldownMissle == true )  
        {
            imageCooldownMissle.fillAmount += 1 / cooldownMissle * Time.deltaTime;

            if (imageCooldownMissle.fillAmount >= 1)
            {
                imageCooldownMissle.fillAmount = 0;
                isCooldownMissle = false;
                missiles.isMissleGo = false;
            }
        }


        //shield
        if (shieldAbility.isShieldGo == true)
        {
            isCooldownShield = true;
        }

        if (isCooldownShield == true)
        {
            imageCooldownShield.fillAmount += 1 / cooldownShield * Time.deltaTime;

            if (imageCooldownShield.fillAmount >= 1)
            {
                imageCooldownShield.fillAmount = 0;
                isCooldownShield = false;
                shieldAbility.isShieldGo = false;
                shieldAbility.shield.SetActive(false);
            }
        }





    }




   
}
