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
        Debug.Log("animator");
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
        if(Input.GetKey(KeyCode.Space)) {
            animator.SetBool("isJumping", true);
        } else if(!Input.GetKey(KeyCode.Space)) {
            animator.SetBool("isJumping", false);
        }
    }
}
