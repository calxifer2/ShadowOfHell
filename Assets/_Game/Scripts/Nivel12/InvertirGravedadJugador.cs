using UnityEngine;

public class InvertirGravedadJugador : MonoBehaviour
{
    // Referencia al Rigidbody2D del jugador
    private Rigidbody2D rb2D;

    void Start()
    {
        // Obtener el Rigidbody2D del jugador
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Función para invertir la gravedad del jugador
    public void Invertir()
    {
        // Invertir la gravedad del Rigidbody2D
        rb2D.gravityScale *= -1;
    }
}
