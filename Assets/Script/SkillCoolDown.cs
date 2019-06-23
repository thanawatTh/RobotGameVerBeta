﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour
{
    //dash
    public Image imageCooldownDash;
    private float cooldownDash = 1;
    public bool isCooldownDash;
    private AbilityDash abilityDash;


    //missle
    public Image imageCooldownMissle;
    private float cooldownMissle = 5;
    public bool isCooldownMissle;
    private Missiles missiles;

    //shield
    public Image imageCooldownShield;
    private float cooldownShield = 10;
    public bool isCooldownShield;
    private ShieldAbility shieldAbility;
    private float time;
    bool timeEnd = false;
    bool fade, fadeStart;

    // Start is called before the first frame update
    void Start()
    {
        abilityDash = GetComponent<AbilityDash>();
        missiles = GetComponent<Missiles>();
        shieldAbility = GetComponent<ShieldAbility>();
        time = 10.0f;

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
        if (time >= 0 )
        {
            time -= Time.deltaTime;


        }

        if (time <= 0)
        {
             //shieldAbility.shield.SetActive(false);

            if (shieldAbility.isShieldGo == true)
            {
                isCooldownShield = true;
                shieldAbility.shield.SetActive(false);
                shieldAbility.image.enabled = false;
            }
                       
            
            if (isCooldownShield == true)
             {

                 imageCooldownShield.fillAmount += 1 / cooldownShield * Time.deltaTime;

                    if (imageCooldownShield.fillAmount >= 1)
                    {
                        

                        imageCooldownShield.fillAmount = 0;
                        isCooldownShield = false;
                        shieldAbility.isShieldGo = false;
                        timeEnd = true;
                        time = 10.0f;
                    }

                    
                }
            
           

        }

        
    }


}

    




