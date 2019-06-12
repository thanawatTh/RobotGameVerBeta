using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthContorller : MonoBehaviour
{
    public float health = 100;
    public float startHealth;
    public Image healthBarImage;

    bool isDie;

    // Start is called before the first frame update
    void Start()
    {
       startHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera.main.WorldToScreenPoint    
    }

    public void TakeDamge(int damage)
    {
        health = health - damage;
        healthBarImage.fillAmount = health / startHealth;
    }

    public void Die()
    {
        if (health <= 0)
        {
            isDie = true;
            
        }
    }
    
}
