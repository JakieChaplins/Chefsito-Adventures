using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsController : MonoBehaviour
{
    public bool burbuja;
    public bool llamas;
    public bool pedetes;

    void Start()
    {
        burbuja = false;
        llamas = false;
        pedetes = false;
        gameObject.transform.GetChild(3).gameObject.SetActive(false);

    }

    void Update()
    {
        
    }

    public void Cebolla()
    {
        burbuja = true;
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }

    public void DesCebolla()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
    }

    public void Guindilla()
    {
        llamas = true;
    }

    public void Judias()
    {
        pedetes = true;
    }

}
