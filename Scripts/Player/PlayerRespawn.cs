using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] PowerUpsController PowerUp;

    public GameObject[] heartscontroller;

    private int heartscount;
    private int hearts;

    public bool Damaged;

    public Animator animator;

    void Start()
    {
        Damaged = false;

        hearts = 3;
        heartscontroller[0].SetActive(true);
        heartscontroller[1].SetActive(true);
        heartscontroller[2].SetActive(true);
        heartscount = 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kill"))
        {
            if (Damaged == false)
            {
                if (PowerUp.burbuja == true)
                {
                    PowerUp.burbuja = false;
                    Damaged = true;
                    PowerUp.DesCebolla();
                    Invoke("DamagedM", 2);
                }
                else
                {
                    animator.SetBool("Hit", true);
                    if (hearts > 1)
                    {
                        Hearts();
                        Damaged = true;
                        Invoke("Hitted", 1);
                        Invoke("DamagedM", 2);
                    }
                    else
                    {
                        Invoke("CargarScene", 0.5f);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Cheese"))
        {
            if (hearts < 3)
            {
                hearts = hearts + 1;
                heartscount = heartscount + 1;
                heartscontroller[heartscount].SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Kill"))
        {
            if (Damaged == false)
            {
                if (PowerUp.burbuja == true)
                {
                    PowerUp.burbuja = false;
                    Damaged = true;
                    PowerUp.DesCebolla();
                    Invoke("DamagedM", 2);
                }
                else
                {
                    animator.SetBool("Hit", true);
                    if (hearts > 1)
                    {
                        Hearts();
                        Damaged = true;
                        Invoke("Hitted", 1);
                        Invoke("DamagedM", 2);
                    }
                    else
                    {
                        Invoke("CargarScene", 0.5f);
                    }
                }
            }
        }
    }

        public void CargarScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Hitted()
    {
        animator.SetBool("Hit", false);
    }

    public void DamagedM()
    {
        Damaged = false;
    }

    public void Hearts()
    {
        if (heartscount > 0)
        {
            hearts--;
            heartscontroller[heartscount].SetActive(false);
            heartscount--;
        }
        else
        {
            heartscontroller[heartscount].SetActive(false);
        }
    }
}
