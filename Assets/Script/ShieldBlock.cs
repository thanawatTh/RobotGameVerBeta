using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBlock : MonoBehaviour
{
    public HealthContorller health;
    public bool notDamage;
    // Start is caled before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TestEnamy")
        {
            notDamage = true;
            Debug.Log("Blockkk");
        }
    }
}
