using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDash : MonoBehaviour
{
    
    public float distace = 5.0f;
    // Start is called before the first frame update
   

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
        Vector3 destination = transform.position + transform.forward * distace;

       /* if (Physics.Linecast(transform.position, destination, out hit)) 
        {
            destination = transform.position + transform.forward * (hit.distance - 1f);
        }*/


        if (Physics.Raycast(destination, -Vector3.up, out hit))
        {
            destination = hit.point;
            destination.y = 0.5f;
            transform.position = destination;
        }


    }
}
