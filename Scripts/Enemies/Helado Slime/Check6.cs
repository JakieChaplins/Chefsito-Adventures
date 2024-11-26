using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check6 : MonoBehaviour
{
    public bool checkYes6;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes6 = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes6 = false;
        }
    }
}
