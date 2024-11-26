using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check4 : MonoBehaviour
{
    public bool checkYes4;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes4 = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes4 = false;
        }
    }
}
