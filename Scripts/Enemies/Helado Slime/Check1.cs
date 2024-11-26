using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check1 : MonoBehaviour
{
    public bool checkYes;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes = false;
        }
    }
}
