using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //Walking animation
        if(Input.GetKey(KeyCode.W)) {
            animator.SetBool("isWalking", true);
        } else if(!Input.GetKey(KeyCode.W)) {
            animator.SetBool("isWalking", false);
        }

        //Running animation
        if(Input.GetKey(KeyCode.LeftShift)) {
            animator.SetBool("isRunning", true);
        } else if(!Input.GetKey(KeyCode.LeftShift)) {
            animator.SetBool("isRunning", false);
        }

        //Jumping animation
        if(Input.GetButton("Jump")) {
            animator.SetBool("isJumping", true);
        } else if(!Input.GetButtonUp("Jump")) {
            animator.SetBool("isJumping", false);
        }

        //Crouching idle animation
        if(Input.GetKey(KeyCode.LeftControl)) {
            animator.SetBool("isCrouchingIdle", true);
        } else if(!Input.GetKey(KeyCode.LeftControl)) {
            animator.SetBool("isCrouchingIdle", false);
        }

        //Walking backwards animation
        if(Input.GetKey(KeyCode.S)) {
            animator.SetBool("isWalkingBackwards", true);
        } else if(!Input.GetKey(KeyCode.S)) {
            animator.SetBool("isWalkingBackwards", false);
        }

        //Walking left animation
        if(Input.GetKey(KeyCode.A)) {
            animator.SetBool("isWalkingLeft", true);
        } else if(!Input.GetKey(KeyCode.A)) {
            animator.SetBool("isWalkingLeft", false);
        }

        //Walking right animation
        if(Input.GetKey(KeyCode.D)) {
            animator.SetBool("isWalkingRight", true);
        } else if(!Input.GetKey(KeyCode.D)) {
            animator.SetBool("isWalkingRight", false);
        }
    }
}
