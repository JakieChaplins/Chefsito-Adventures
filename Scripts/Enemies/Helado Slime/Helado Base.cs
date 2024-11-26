using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Check1 check1;
    [SerializeField] Check2 check2;
    [SerializeField] Check3 check3;
    [SerializeField] Check4 check4;
    [SerializeField] Check5 check5;
    [SerializeField] Check6 check6;
    [SerializeField] HeladoSpriter HSprite;

    Rigidbody2D rb2D;

    public float runSpeed;
    public float jumpSpeed;

    private bool direction;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        direction = false;
    }

    void Update()
    {
        if (direction == false)
        {
            HSprite.FlipHeladoFalse();
            if (check2.checkYes2 == false)
            {
                if (check1.checkYes == false)
                {
                    if (check3.checkYes3 == true)
                    {
                        rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = true;
                    }
                }
                if (check1.checkYes == true)
                {
                    direction = true;
                }
            }
            else
            {
                if (check1.checkYes == true)
                {
                    direction = true;
                }
                else
                {
                    rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }
        }

        if (direction == true)
        {
            HSprite.FlipHeladoTrue();
            if (check5.checkYes5 == false)
            {
                if (check4.checkYes4 == false)
                {
                    if (check6.checkYes6 == true)
                    {
                        rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = false;
                    }
                }
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
            }
            else
            {
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
                else
                {
                    rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }
        }
    }
}
