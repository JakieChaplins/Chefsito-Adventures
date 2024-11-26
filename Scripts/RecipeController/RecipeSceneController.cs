using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RecipeSceneController : MonoBehaviour
{
    public GameObject IngredientsCollection;
    public static int IngredientsRemaining;

    public TextMeshProUGUI textIngredientsTotal;
    public TextMeshProUGUI textIngredientsCollected;


    void Start()
    {
        IngredientsRemaining = IngredientsCollection.gameObject.transform.childCount;
        textIngredientsTotal.text = IngredientsCollection.gameObject.transform.childCount.ToString();
        checkIngredientsRemaining();
    }

    public void checkIngredientsRemaining()
    {
        textIngredientsCollected.text = (int.Parse(textIngredientsTotal.text) - IngredientsRemaining).ToString();
    }
}
