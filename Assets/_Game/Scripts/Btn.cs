using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{

    public bool presionado;
    public float velocidad;
    public Transform pOn;
    public Transform pOff;
    public Transform graficos;

    void Update()
    {

        graficos.position = Vector3.Lerp(graficos.position, presionado ? pOn.position : pOff.position, velocidad * Time.deltaTime);

    }

}
