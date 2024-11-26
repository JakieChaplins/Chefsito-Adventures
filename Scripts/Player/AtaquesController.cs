using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquesController : MonoBehaviour
{
    [SerializeField] PowerUpsController PowerUp;
    [SerializeField] PlayerController Player;

    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public Transform launchSpawnPoint;
    public Transform launchSpawnPoint2;

    public Animator animator;

    private float waitedTime = 0;
    public float waitTimeToAttack = 0.85f;

    void Start()
    {
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(5).gameObject.SetActive(false);
        gameObject.transform.GetChild(6).gameObject.SetActive(false);
        gameObject.transform.GetChild(7).gameObject.SetActive(false);
    }

    void Update()
    {       
        if (PowerUp.llamas == true)
        {
            waitedTime -= Time.deltaTime;
            if (waitedTime <= 0)
            {
                if (Player.direccion == false)
                {
                    gameObject.transform.GetChild(5).gameObject.SetActive(true);
                    gameObject.transform.GetChild(4).gameObject.SetActive(false);
                    if (Input.GetKey("mouse 0"))
                    {
                        GameObject newBullet;

                        newBullet = Instantiate(bulletPrefab, launchSpawnPoint.position, launchSpawnPoint.rotation);
                        waitedTime = waitTimeToAttack;
                    }
                }


                if (Player.direccion == true)
                {
                    gameObject.transform.GetChild(5).gameObject.SetActive(false);
                    gameObject.transform.GetChild(4).gameObject.SetActive(true);
                    if (Input.GetKey("mouse 0"))
                    {
                        GameObject newBullet;

                        newBullet = Instantiate(bulletPrefab2, launchSpawnPoint2.position, launchSpawnPoint2.rotation);
                        waitedTime = waitTimeToAttack;
                    }
                }
            }
        }

        waitedTime -= Time.deltaTime;
        if (waitedTime <= 0)
        {
            if (Player.direccion == false)
            {
                if (Input.GetKey("mouse 0"))
                {
                    gameObject.transform.GetChild(6).gameObject.SetActive(true);
                    gameObject.transform.GetChild(7).gameObject.SetActive(false);
                    animator.SetBool("Attack", true);
                    waitedTime = waitTimeToAttack;
                    Invoke("Desatacar", 0.5f);
                }
            }


            if (Player.direccion == true)
            {
                if (Input.GetKey("mouse 0"))
                {
                    gameObject.transform.GetChild(6).gameObject.SetActive(false);
                    gameObject.transform.GetChild(7).gameObject.SetActive(true);
                    animator.SetBool("Attack", true);
                    waitedTime = waitTimeToAttack;
                    Invoke("Desatacar", 0.5f);
                }
            }
        }
    }

    public void Desatacar()
    {
        animator.SetBool("Attack",false);
        gameObject.transform.GetChild(6).gameObject.SetActive(false);
        gameObject.transform.GetChild(7).gameObject.SetActive(false);
    }
}
