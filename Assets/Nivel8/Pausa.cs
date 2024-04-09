using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject imgPausa;
    public GameObject imgPlay;
    public GameObject imgOscura;

    // Variable para controlar si el juego está pausado
    private bool juegoPausado = false;

    // Método para pausar o reanudar el juego
    public void PausaReanudar()
    {
        if (!juegoPausado)
        {
            // Pausar el juego
            Time.timeScale = 0;
            imgPausa.SetActive(true);
            imgPlay.SetActive(false);
            imgOscura.SetActive(true);
            juegoPausado = true;
        }
        else
        {
            // Reanudar el juego
            Time.timeScale = 1;
            imgPausa.SetActive(false);
            imgPlay.SetActive(true);
            imgOscura.SetActive(false);
            juegoPausado = false;
        }
    }

    // Método para desbloquear o bloquear los eventos de los botones
    public void DesbloquearEventosDeBotones(bool desbloquear)
    {
        // Obtener todos los botones en la escena
        UnityEngine.UI.Button[] botones = FindObjectsOfType<UnityEngine.UI.Button>();

        // Iterar sobre cada botón y ajustar su interactividad
        foreach (UnityEngine.UI.Button boton in botones)
        {
            boton.interactable = desbloquear;
        }
    }
}



