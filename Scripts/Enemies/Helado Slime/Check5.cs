using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check5 : MonoBehaviour
{
    public bool checkYes5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes5 = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes5 = false;
        }
    }
}
