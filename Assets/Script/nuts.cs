using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuts : MonoBehaviour
{
    public HealthContorller healthContorller;
    public bool test;

    // Start is called before the first frame update
    void Start()
    {
        test = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 150 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (healthContorller.isFull == true)
        {
            test = false;
        }


        if (test == true && healthContorller.health < 100) 
        {
            if (other.gameObject.tag == "Player")
            {
                healthContorller.healHp(20);
                Destroy(gameObject, 0.5f);
            }
        }
       

    }
}
