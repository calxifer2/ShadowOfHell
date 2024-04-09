using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    // Velocidad de movimiento del jugador
    public float velocidadMovimiento = 5f;

    void Update()
    {
        // Verificar si estás en el nivel deseado
        if (ManagerGame.instance.currentLevel == 8)
        {
            // Verificar si hay al menos un toque en la pantalla
            if (Input.touchCount > 0)
            {
                // Obtener el primer toque en la pantalla
                Touch primerToque = Input.GetTouch(0);

                // Obtener la posición del toque en la pantalla
                Vector3 posicionToque = Camera.main.ScreenToWorldPoint(primerToque.position);
                posicionToque.z = 0f; // Ajustar la posición en z para que esté en el mismo plano que el jugador

                // Calcular la dirección del movimiento del jugador
                Vector3 direccionMovimiento = (posicionToque - transform.position).normalized;

                // Mover al jugador en la dirección del toque
                transform.position += direccionMovimiento * velocidadMovimiento * Time.deltaTime;
            }
        }
    }
}
