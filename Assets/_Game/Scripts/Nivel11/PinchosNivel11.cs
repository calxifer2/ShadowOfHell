using UnityEngine;

public class PinchosNivel11 : MonoBehaviour
{
    public Animator anim;
    public Movements movimiento;
    public Puerta puerta; // Referencia al script de la puerta que se abrir�

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            anim.SetBool("Die", true);
            enabled = false;
            Debug.Log("Pinchooos");

            // Abre la puerta si la referencia a la puerta est� configurada y la puerta no est� ya abierta
            if (puerta != null && !puerta.abierta)
            {
                puerta.abierta = true;
            }
        }
    }
}
