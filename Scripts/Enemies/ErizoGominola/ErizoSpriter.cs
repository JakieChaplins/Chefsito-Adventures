using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErizoSpriter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void FlipErizoFalse()
    {
        spriteRenderer.flipX = false;
    }

    public void FlipErizoTrue()
    {
        spriteRenderer.flipX = true;
    }

    public void Shooting()
    {
        animator.SetBool("Attack", true);
    }

    public void NoShooting()
    {
        animator.SetBool("Attack", false);
    }
}
