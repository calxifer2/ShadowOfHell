using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{

    public bool abierta;
    public float velocidad;
    public Transform pAbierta;
    public Transform pCerrada;
    public Transform graficos;
    

    void Update()
    {

        graficos.position = Vector3.Lerp(graficos.position, abierta? pAbierta.position : pCerrada.position, velocidad * Time.deltaTime);

    }

}
