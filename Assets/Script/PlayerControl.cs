using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody rigidBody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;

    public Ray cameraRay;

    TouchControl joyInputMove;
    TouchRotControl joyInputRot;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        mainCamera = Camera.main;

        joyInputMove = GameObject.Find("JoyMove").GetComponent<TouchControl>();
       // joyInputRot = GameObject.Find("JoyRot").GetComponent<TouchRotControl>();
    }

    
    void Update()
    {

        //Touch
        /////////////////////////////////////////////////////////////////////////////
        moveInput = new Vector3(joyInputMove.joyInput.x, 0, joyInputMove.joyInput.y);
        moveVelocity = moveInput * moveSpeed;

        Vector2 from = new Vector2(0,1);
        Vector2 to = joyInputMove.rotationInput;

        transform.localEulerAngles = new Vector3(0f, -30 - Vector2.SignedAngle(from, to), 0f);//หามุมของแกนy





        //rotation right

        /*Vector2 from = new Vector2(0, 1);
        Vector2 to = joyInputRot.rotInput;

        transform.localEulerAngles = new Vector3(0f, -30 - Vector2.SignedAngle(from, to), 0f);//หามุมของแกนy

         */     

        /* KeyBroad
         /////////////////////////////////////////////////////////////////////////////////////////////
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
           }*/
        /////////////////////////////////////////////////////////////////////////////////////////////

    }

    void FixedUpdate()
    {
        rigidBody.velocity = moveVelocity;

    }
}
