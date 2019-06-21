using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthContorller : MonoBehaviour
{
    public float health = 100;
    public float startHealth;
    public Image healthBarImage;

    public ParticleSystem dead;

    public GameObject player;

    public GameObject hpBar;

    public bool isDie;
  
    // Start is called before the first frame update
    void Start()
    {
       startHealth = health;
        isDie = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            isDie = true;
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        
       
        
    }

    public void TakeDamge(int damage)
    {
        health = health - damage;
        healthBarImage.fillAmount = health / startHealth;
    }


   


}
