using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb2D;

    public float runSpeed;
    public float jumpSpeed;

    public int jumpNum;

    public bool direccion;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        direccion = true;
    }

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            direccion = false;
        }
        else if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            direccion = true;
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && jumpNum > 0)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            jumpNum = jumpNum - 1;
        }
    }
}
