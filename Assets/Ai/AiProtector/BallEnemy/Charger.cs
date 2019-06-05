using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour
{

    public float Speed = 200f;
    public Transform chargerEnd;
    public float chargerRange = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (gameObject.tag == "Player")
        {

            Rigidbody chargerEnemy;
            transform.position = Vector3.MoveTowards(transform.position, chargerEnd.position, Speed * Time.deltaTime);
            Debug.Log("Speed");
            

        }

    }
    
  
}

