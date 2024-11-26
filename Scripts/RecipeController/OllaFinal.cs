using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OllaFinal : MonoBehaviour
{
    [SerializeField] MenusVarios Menus;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (RecipeSceneController.IngredientsRemaining == 0)
        {
            if (RecipeSceneController1.IngredientsRemaining1 == 0)
            {
                if (RecipeSceneController2.IngredientsRemaining2 == 0)
                {
                    Menus.MenusPausaOpciones[2].SetActive(true);
                    Time.timeScale = 0;
                    Menus.Paused = true;
                }
            }
        }
    }
}
