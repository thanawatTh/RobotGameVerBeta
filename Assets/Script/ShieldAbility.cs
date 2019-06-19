using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAbility : MonoBehaviour
{

    public GameObject shield;
    public Transform player;
    //public HealthContorller health;

    [HideInInspector]
    public bool showShield;
    public bool isShieldGo;
    

    // Start is called before the first frame update
    void Start()
    {
        shield.SetActive(false);
        showShield = false;
        
        player = GameObject.Find("Body").GetComponent<Transform>();
       

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
