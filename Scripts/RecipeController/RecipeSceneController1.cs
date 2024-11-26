using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RecipeSceneController1 : MonoBehaviour
{
    public GameObject IngredientsCollection1;
    public static int IngredientsRemaining1;

    public TextMeshProUGUI textIngredientsTotal1;
    public TextMeshProUGUI textIngredientsCollected1;


    void Start()
    {
        IngredientsRemaining1 = IngredientsCollection1.gameObject.transform.childCount;
        textIngredientsTotal1.text = IngredientsCollection1.gameObject.transform.childCount.ToString();
        checkIngredientsRemaining1();
    }

    public void checkIngredientsRemaining1()
    {
        textIngredientsCollected1.text = (int.Parse(textIngredientsTotal1.text) - IngredientsRemaining1).ToString();
    }
}
