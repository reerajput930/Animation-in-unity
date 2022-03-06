using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanAnimation : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
        //animator.SetBool("isWalking",false);       
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool fastWalking = animator.GetBool("fastWalking");
        bool jump = animator.GetBool("jump");
        bool dance = animator.GetBool("dance");
        bool leftView = animator.GetBool("leftView");
        bool rightView = animator.GetBool("rightView");

        bool forwardPressed = Input.GetKey("w");
        bool fastPressed = Input.GetKey("left shift");
        bool jumpPressed = Input.GetKey("space");
        bool dancePressed = Input.GetKey("q");
        bool leftViewPressed = Input.GetKey("a");
        bool rightViewPressed = Input.GetKey("d");

        //is walking
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        //walk -- then fast move
        //that means , fast walking possible only when the body is walking
        if ((forwardPressed) && (!fastWalking && fastPressed))
        {
            animator.SetBool("fastWalking", true);
        }
        if ((forwardPressed || !forwardPressed) && fastWalking && !fastPressed)
        {
            animator.SetBool("fastWalking", false);

        }

        //making things jump
        if ((!isWalking && forwardPressed) || !jump && jumpPressed)
        {
            animator.SetBool("jump", true);
        }
        if ((isWalking && !forwardPressed) || (jump && !jumpPressed))
        {
            animator.SetBool("jump", false);
        }
        if (!dance && dancePressed)
        {
            animator.SetBool("dance", true);
        }
        if (dance && !dancePressed)
        {
            animator.SetBool("dance", false);
        }
        if ((isWalking && forwardPressed) && (!leftView && leftViewPressed))
        {
            animator.SetBool("leftView", true);
        }
        if ((forwardPressed || !forwardPressed) && leftView && !leftViewPressed)
        {
            animator.SetBool("leftView", false);
        }

        if ((isWalking && forwardPressed) && (!rightView && rightViewPressed))
        {
            animator.SetBool("rightView", true);
        }
        if ((forwardPressed || !forwardPressed) && rightView && !rightViewPressed)
        {
            animator.SetBool("rightView", false);
        }

    }
}
