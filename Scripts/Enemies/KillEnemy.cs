using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public Animator animator;

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("KillEnemy"))
        {
            animator.SetBool("Dead", true);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject,0.8f);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("KillEnemy"))
        {
            animator.SetBool("Dead", true);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject,0.8f);
        }
    }
}
