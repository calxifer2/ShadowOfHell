using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Menú");
    } 
}