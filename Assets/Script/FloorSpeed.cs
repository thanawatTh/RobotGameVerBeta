using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpeed : MonoBehaviour
{
    private float forcePower = 1000f;
   

    // Start is called before the first frame update

    private void Start()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          
            Rigidbody rigi = other.GetComponent<Rigidbody>();
            rigi.AddForce(Vector3.forward * forcePower * 10);
            Debug.Log("Speed");
        }
    }

}
