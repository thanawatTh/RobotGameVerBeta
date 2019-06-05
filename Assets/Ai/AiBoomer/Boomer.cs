using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Boomer : MonoBehaviour
{
   
    public float lookRaius = 5f;
    public float lookIn = 2f;
    //public float speed;

    
    public NavMeshAgent agent;

    public GameObject booMer;
    public ParticleSystem booM;

    public Transform target;

    void Start()
    {
        target = PlayerManager.instance.main.transform;
        agent = GetComponent<NavMeshAgent>();
       

        
    }

    
    void Update()
    {
        
        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);
        if( distance <= lookRaius)
        {
            agent.SetDestination(target.position);
        }

        if (distance <= lookIn)
        {
            Instantiate(booM, transform.position, Quaternion.identity);
            Destroy(booMer);       
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRaius);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookIn);

    }


     


}
