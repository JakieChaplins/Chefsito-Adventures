using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilErizo2 : MonoBehaviour
{
   // [SerializeField] BaseTrunk Trunk;

    SpriteRenderer spriteRenderer;

    public float speed = 2;
    public float lifeTime = 2;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {

        transform.Translate(new Vector2(speed,4*speed) * Time.deltaTime);

    }
}
