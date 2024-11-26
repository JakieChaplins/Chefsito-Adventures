using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenusVarios : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public bool Paused;

    public GameObject[] MenusPausaOpciones;

    void Start()
    {
        Paused = false;
        MenusPausaOpciones[0].SetActive(false);
        MenusPausaOpciones[1].SetActive(false);
        MenusPausaOpciones[2].SetActive(false);
        MenusPausaOpciones[3].SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused == false)
            {
                MenusPausaOpciones[0].SetActive(true);
                Time.timeScale = 0;
                Paused = true;
            }
            else
            {
                MenusPausaOpciones[0].SetActive(false);
                MenusPausaOpciones[1].SetActive(false);
                Time.timeScale = 1;
                Paused = false;
            }
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        Paused = false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void CambiarVolumen(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void ReanudarBoton()
    {
        MenusPausaOpciones[0].SetActive(false);
        MenusPausaOpciones[1].SetActive(false);
        Time.timeScale = 1;
        Paused = false;
    }

    public void OpcionesBoton()
    {
        MenusPausaOpciones[0].SetActive(false);
        MenusPausaOpciones[1].SetActive(true);
        MenusPausaOpciones[3].SetActive(false);

    }

    public void VolverBoton()
    {      
        MenusPausaOpciones[1].SetActive(false);
        MenusPausaOpciones[0].SetActive(true);
        MenusPausaOpciones[3].SetActive(true);
    }

    public void MenuBoton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
