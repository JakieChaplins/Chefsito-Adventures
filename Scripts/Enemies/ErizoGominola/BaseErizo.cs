using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseErizo : MonoBehaviour
{
    [SerializeField] Check1 check1;
    [SerializeField] Check2 check2;
    [SerializeField] Check3 check3;
    [SerializeField] Check4 check4;
    [SerializeField] Check5 check5;
    [SerializeField] Check6 check6;
    [SerializeField] CheckShoot Shoot;
    [SerializeField] ErizoSpriter ESprite;

    Rigidbody2D rb2D;

    public float runSpeed;
    public float jumpSpeed;

    public bool direction;
    private bool ItsShooting;

    private float waitedTime;
    public float waitTimeToAttack = 3;
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public GameObject bulletPrefab4;
    public Transform launchSpawnPoint;
    public Transform launchSpawnPoint2;
    public Transform launchSpawnPoint3;
    public Transform launchSpawnPoint4;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        direction = false;
        waitedTime = waitTimeToAttack;
    }

    void Update()
    {
        if (direction == false)
        {
            ESprite.FlipErizoFalse();


            if (Shoot.checkShoot == true)
            {
                runSpeed = 0;
                //ESprite.Shooting();

                if (waitedTime <= 0)
                {
                    waitedTime = waitTimeToAttack;
                    direction = false;
                    LaunchBullet();

                }
                else
                {
                    waitedTime -= Time.deltaTime;
                }
            }

            if (Shoot.checkShoot == false)
            {
                runSpeed = 1;
                //ESprite.NoShooting();

            }

            if (check2.checkYes2 == false)
            {
                if (check1.checkYes == false)
                {
                    if (check3.checkYes3 == true)
                    {
                        rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = true;
                    }
                }
                if (check1.checkYes == true)
                {
                    direction = true;
                }
            }
            else
            {
                if (check1.checkYes == true)
                {
                    direction = true;
                }
                else
                {
                    rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }
        }

        if (direction == true)
        {
            ESprite.FlipErizoTrue();

            if (Shoot.checkShoot == true)
            {
                runSpeed = 0;
                //ESprite.Shooting();

                if (waitedTime <= 0)
                {
                    waitedTime = waitTimeToAttack;
                    direction = true;
                    LaunchBullet();
                }
                else
                {
                    waitedTime -= Time.deltaTime;
                }
            }

            if (Shoot.checkShoot == false)
            {
                runSpeed = 1;
                //ESprite.NoShooting();

            }


            if (check5.checkYes5 == false)
            {
                if (check4.checkYes4 == false)
                {
                    if (check6.checkYes6 == true)
                    {
                        rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = false;
                    }
                }
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
            }
            else
            {
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
                else
                {
                    rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }
        }
    }

    public void LaunchBullet()
    {
        GameObject newBullet;

        newBullet = Instantiate(bulletPrefab, launchSpawnPoint.position, launchSpawnPoint.rotation);

        GameObject newBullet2;

        newBullet2 = Instantiate(bulletPrefab2, launchSpawnPoint2.position, launchSpawnPoint2.rotation);

        GameObject newBullet3;

        newBullet3 = Instantiate(bulletPrefab3, launchSpawnPoint3.position, launchSpawnPoint3.rotation);

        GameObject newBullet4;

        newBullet4 = Instantiate(bulletPrefab4, launchSpawnPoint4.position, launchSpawnPoint4.rotation);
    }
}
