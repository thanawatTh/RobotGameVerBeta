using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileFollowTarget : MonoBehaviour
{
    public Transform target;
    public Rigidbody missleRigibody;


    public float turn;
    public float missleVelocity;
    

    // Start is called before the first frame update

    void Start()
    {

        target = GameObject.FindGameObjectWithTag("TestEnamy").transform;
        
    }
    private void FixedUpdate()
    {
        
      // missleRigibody.velocity = transform.forward * missleVelocity;

       var missleTargetRotation = Quaternion.LookRotation(target.position - transform.position);

        if (missleTargetRotation != null && target != null) 
        {
            missleRigibody.velocity = transform.forward * missleVelocity;
            missleRigibody.MoveRotation(Quaternion.RotateTowards(transform.rotation, missleTargetRotation, turn));

        }
       

        
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TestEnamy")
            {

                Destroy(gameObject);
                Debug.Log("i found target");
            }

        else
        {

        }

        
           
    }

}
