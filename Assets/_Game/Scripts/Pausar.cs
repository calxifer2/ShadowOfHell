using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar : MonoBehaviour
{
    public GameObject imgPausa;
    public GameObject imgPlay;
    public GameObject imgOscura;

    public void PausarReanudar()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            imgPausa.SetActive(true);
            imgPlay.SetActive(false);
            imgOscura.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            imgPausa.SetActive(false);
            imgPlay.SetActive(true);
            imgOscura.SetActive(true);
        }
    }

    
}
