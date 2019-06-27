using System.Collections;
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
    private float cooldownMissle = 50;
    public bool isCooldownMissle;
    private Missiles missiles;

    //shield
    public Image imageCooldownShield;
    private float cooldownShield = 10;
    public bool isCooldownShield;
    private bool isWaitingForShieldGone = false;
    private ShieldAbility shieldAbility;
    private float time = 0f;
    bool timeEnd = false;
    public GameObject block;
  
    

    // Start is called before the first frame update
    void Start()
    {
        abilityDash = GetComponent<AbilityDash>();
        missiles = GetComponent<Missiles>();
        shieldAbility = GetComponent<ShieldAbility>();
        block.SetActive(false);
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
        if (isWaitingForShieldGone)
        {
            //Debug.Log("Wait " + isWaitingForShieldGone);
            if (time >= 0 && shieldAbility.isShieldGo ) 
            {
                Debug.Log("Wait1 " + isWaitingForShieldGone);
                time -= Time.deltaTime;
                
            }
            else
            {
                Debug.Log("Wait2 " + isWaitingForShieldGone);
                shieldAbility.isShieldGo = false;
                isWaitingForShieldGone = false;
                shieldAbility.shield.SetActive(false);
                shieldAbility.image.enabled = false;
               
                
                //time = 2f;
            }
            //time = 10.0f;

        }
        else
        {
            Debug.Log("not Wait");
            //shieldAbility.shield.SetActive(false);
            Debug.Log("isShieldGo "+shieldAbility.isShieldGo);
            if (shieldAbility.isShieldGo == true)
            {
                isCooldownShield = true;
                shieldAbility.shield.SetActive(true);
                shieldAbility.image.enabled = true;
                isWaitingForShieldGone = true;
                time = 10f;
                block.SetActive(true);


            }
                       
            
            if (isCooldownShield == true &&!isWaitingForShieldGone)
            {

                imageCooldownShield.fillAmount += 1 / cooldownShield * Time.deltaTime;

                if (imageCooldownShield.fillAmount >= 1)
                {
                        

                    imageCooldownShield.fillAmount = 0;
                    isCooldownShield = false;
                    shieldAbility.isShieldGo = false;
                    isWaitingForShieldGone = true;
                    block.SetActive(false);
                    //timeEnd = true;
                    //time = 2.0f;
                }

                

            }

                     


        }

        




    }


}

    




