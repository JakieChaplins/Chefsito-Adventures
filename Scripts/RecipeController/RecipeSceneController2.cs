using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RecipeSceneController2 : MonoBehaviour
{
    public GameObject IngredientsCollection2;
    public static int IngredientsRemaining2;

    public TextMeshProUGUI textIngredientsTotal2;
    public TextMeshProUGUI textIngredientsCollected2;


    void Start()
    {
        IngredientsRemaining2 = IngredientsCollection2.gameObject.transform.childCount;
        textIngredientsTotal2.text = IngredientsCollection2.gameObject.transform.childCount.ToString();
        checkIngredientsRemaining2();
    }

    public void checkIngredientsRemaining2()
    {
        textIngredientsCollected2.text = (int.Parse(textIngredientsTotal2.text) - IngredientsRemaining2).ToString();
    }
}
