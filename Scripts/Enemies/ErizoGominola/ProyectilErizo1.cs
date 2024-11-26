using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilErizo1 : MonoBehaviour
{
   // [SerializeField] BaseTrunk Trunk;

    SpriteRenderer spriteRenderer;

    public float speed = 2;
    public float lifeTime = 1;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {

        transform.Translate(new Vector2(0.0f, 3*speed) * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
