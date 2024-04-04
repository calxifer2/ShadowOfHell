using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Nvl_0 : MonoBehaviour
{

    public Btn boton;
    public Puerta puerta;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            boton.presionado = true;
            puerta.abierta = true;
        }
    }

}
