using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldAbility : MonoBehaviour
{

    public GameObject shield;
    public Transform player;
    //public HealthContorller health;
    public Image image;

    [HideInInspector]
    public bool showShield;
    public bool isShieldGo;
    private Animator anim;
    public SkillCoolDown skillCoolDown;
    

    // Start is called before the first frame update
    void Start()
    {
        shield.SetActive(false);
        showShield = false;
        image = GameObject.Find("CooldownShieldBlack").GetComponent<Image>();
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //void ShieldStart()
    //{
        
    //}


   public void OnTouchDown()
    {
        showShield = true;
        image.enabled = true;
        if (showShield)
        {
            if (isShieldGo == false)
            {
                isShieldGo = true;

                if (shield != null)
                {
                    shield.SetActive(true);
                   
                }
            }    
                
                
            }
        }
       
       
    }


   
    




