using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody rigidBody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public Camera mainCamera;

    public Ray cameraRay;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlan = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlan.Raycast(cameraRay,out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.black);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }

     void FixedUpdate()
    {
        rigidBody.velocity = moveVelocity;
    }
}
