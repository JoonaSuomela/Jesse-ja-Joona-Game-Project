using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;



    //Jumping and Gravity variables
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    Vector3 velocity;

    //Runninng variables
    public float RunSpeed = 20f;
    public float NormalSpeed = 12f;
    bool isRunning = false;


    //GroundCheck variables
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    //Crouch vars
    public bool isCrouching = false;
    public float crouchingMultiplier;
    public float crouchingHeight = 1.5f;
    public float standingHeight = 2f;



    // Update is called once per frame
    void Update()
    {
        
        if(!PauseMenu.isPaused) {
            
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;


        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded) 
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) {
 
            isRunning = true;
            speed = RunSpeed;
            
 
        } else {
 
            isRunning = false;
            speed = NormalSpeed;
 
        }

        if(Input.GetKey(KeyCode.LeftControl)) {
            controller.height = crouchingHeight;
            move *= crouchingMultiplier;
        } else {
            controller.height = standingHeight;
        }
        }
    }
}
