using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsCollected2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            RecipeSceneController2.IngredientsRemaining2--;
            GameObject.Find("EventSystem").GetComponent<RecipeSceneController2>().checkIngredientsRemaining2();
        }
    }
}