using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EscenaJuego()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("tutorial");
    }

    public void EscenaMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menú");
    }

    public void EscenaNiveles()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuNiveles");
    }
}

