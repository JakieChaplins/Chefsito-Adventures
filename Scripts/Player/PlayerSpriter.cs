using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriter : MonoBehaviour
{

    [SerializeField] PlayerController playerBase;
    [SerializeField] GroundChecker groundChecker;

    SpriteRenderer spriteRenderer;
    Animator animator;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey("d"))
        {

            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a"))
        {

            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKey("space"))
        {
            animator.SetBool("Jump", true);
        }

        if (groundChecker.isGrounded == false)
        {
            animator.SetBool("Run", false);
            animator.SetBool("Jump", true);       
        }

        if (groundChecker.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }
    }

}
