using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilEyeController : MonoBehaviour
{
    public float speed = 10f;
    public float jumgSpeed = 10f;

    public float distToGround = 0.5f;
    public LayerMask groundLayers;

    Rigidbody rb;

    public float lookRaius = 5f;
    public float lookIn = 2f;

    public NavMeshAgent agent;

    public Transform target;

    public SphereCollider Col;

    #region MonoBehaviour API

    void Start()
    {
        target = GameManager.instance.main.transform;
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        Col = GetComponent<SphereCollider>();
    }
    
    void Update()
    {

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRaius && isGrounded())
        {             
            agent.SetDestination(target.position);

            Vector3 jumgVelocity = new Vector3(0f, jumgSpeed, 0f);
            rb.velocity = rb.velocity + jumgVelocity;
        }

    }


    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRaius);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookIn);

    }

    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround);
    }

    #endregion

}
