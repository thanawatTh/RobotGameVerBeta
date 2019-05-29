using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public HealthContorller healthBar;
    // Start is called before the first frame update

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enamy")
        {
            if (healthBar)
            {
                healthBar.TakeDamge(10);
                Debug.Log("damage");
            }
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enamy") 
        {
                     
                healthBar.TakeDamge(10);
                Debug.Log("damage");
            
        }
    }
}
