using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladoSpriter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FlipHeladoFalse()
    {
        spriteRenderer.flipX = false;
    }

    public void FlipHeladoTrue()
    {
        spriteRenderer.flipX = true;
    }
}
