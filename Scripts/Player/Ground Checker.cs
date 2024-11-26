using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] PowerUpsController PowerUp;

    public bool isGrounded;

    void Update()
    {
      
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (PowerUp.pedetes == true)
            {
                isGrounded = true;
                playerController.jumpNum = 2;
            }
            else
            {
                isGrounded = true;
                playerController.jumpNum = 1;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (PowerUp.pedetes == true)
            {
                isGrounded = false;
                playerController.jumpNum = 1;
            }
            else
            {
                isGrounded = false;
                playerController.jumpNum = 0;
            }
        }
    }
}
