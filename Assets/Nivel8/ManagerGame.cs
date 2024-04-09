using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    public static ManagerGame instance; // Referencia estática al GameManager para acceder desde otros scripts

    public int currentLevel = 1; // Variable para controlar el nivel actual

    // Método Awake para configurar la instancia estática
    private void Awake()
    {
        // Asegurar que solo haya una instancia del GameManager en la escena
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        // No destruir este objeto al cargar una nueva escena
        DontDestroyOnLoad(gameObject);
    }

    // Método para cargar un nuevo nivel
    public void CargarNivel(int nivel)
    {
        // Aquí puedes implementar la lógica para cargar un nuevo nivel
        // Por ejemplo, puedes usar SceneManager.LoadScene() si estás usando Unity SceneManager
    }

    // Otros métodos y funcionalidades del GameManager pueden ir aquí
}

