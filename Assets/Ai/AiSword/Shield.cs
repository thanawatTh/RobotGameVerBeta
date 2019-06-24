using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour

{
    Transform target;
    public Image hpBarPosition;
    public Image hpBar;
    public HealthEnamyContorller healthEnamyContorller;

    void Start()
    {
        target = GameManager.instance.main.transform;
        healthEnamyContorller.starHeathShield = healthEnamyContorller.heathShield;
        hpBarPosition.enabled = true;
        hpBar.enabled = true;
    }


    public void Damage(int damageAmount)
    {

        healthEnamyContorller.heathShield -= damageAmount;
        hpBar.fillAmount = healthEnamyContorller.heathShield / healthEnamyContorller.starHeathShield;

        if (healthEnamyContorller.heathShield <= 0)
        {
            Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);

            gameObject.SetActive(false);
            hpBarPosition.enabled = false;
            hpBar.enabled = false;

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Missle")
            {

                Instantiate(healthEnamyContorller.deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                hpBarPosition.enabled = false;
                hpBar.enabled = false;
            }


        }

    }
}
