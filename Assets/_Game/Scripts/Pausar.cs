using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar : MonoBehaviour
{
    public GameObject imgPausa;
    public GameObject imgPlay;
    public GameObject imgOscura;
    public GameObject Logo;
    public GameObject btnMenu;
    public GameObject btnNiveles;

    public void PausarReanudar()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            imgPausa.SetActive(true);
            imgPlay.SetActive(false);
            imgOscura.SetActive(false);
            Logo.SetActive(false);
            btnMenu.SetActive(false);
            btnNiveles.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            imgPausa.SetActive(false);
            imgPlay.SetActive(true);
            imgOscura.SetActive(true);
            Logo.SetActive(true);
            btnMenu.SetActive(true);
            btnNiveles.SetActive(true);
        }
    }

    
}
