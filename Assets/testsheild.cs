using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testsheild : MonoBehaviour
{
    public ShieldBlock shield;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShieldTag")
        {
            if (shield.notDamage == true) 
            {
                
            }
        }
    }
}
