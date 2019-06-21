using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthContorller : MonoBehaviour
{
    static float health = 100;
    static float startHealth;
    public Image healthBarImage;

    public ParticleSystem dead;

    public GameObject player;

    public GameObject hpBar;

    public bool isDie;
  
    // Start is called before the first frame update
    void Start()
    {
       startHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera.main.WorldToScreenPoint    
        if (health <= 0)
        {

            Instantiate(dead, transform.position, Quaternion.identity);
            player.SetActive(false);
            hpBar.SetActive(false);


            GameObject.FindObjectOfType<GameManager>().EndGame();

            //isDie = true;
        }
    }

    public void TakeDamge(int damage)
    {
        health = health - damage;
        healthBarImage.fillAmount = health / startHealth;
    }


   


}
