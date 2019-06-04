using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDash : MonoBehaviour
{
    
    public float distace = 5.0f;
    private Rigidbody rigiBody;
    
    // Start is called before the first frame update

     void Start()
    {
        rigiBody = GetComponent<Rigidbody>();
        
       
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            {
                DashForward();
            }


        
    }

    public void DashForward()
    {
        RaycastHit hit;
        Vector3 destination = transform.position + transform.forward * distace ;


        //hit block
        if (Physics.Linecast(transform.position , destination, out hit)) 
        {
            destination = transform.position + transform.forward * (hit.distance - 1f);
        }


       //not hit block
       if (Physics.Raycast(destination, -Vector3.up, out hit))
        {
            destination = hit.point;
            destination.y = 1f;
            transform.position = destination;
            
        }
        

    }

   


}
