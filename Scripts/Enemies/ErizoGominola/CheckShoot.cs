using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckShoot : MonoBehaviour
{
    public bool checkShoot;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            checkShoot = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            checkShoot = false;
        }
    }
}
