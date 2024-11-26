using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            Destroy(gameObject);
            //GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
