using UnityEngine;

public class PinchosNivel11 : MonoBehaviour
{
    public Animator anim;
    public Movements movimiento;
    public Puerta puerta; // Referencia al script de la puerta que se abrirá

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            anim.SetBool("Die", true);
            enabled = false;
            Debug.Log("Pinchooos");

            // Abre la puerta si la referencia a la puerta está configurada y la puerta no está ya abierta
            if (puerta != null && !puerta.abierta)
            {
                puerta.abierta = true;
            }
        }
    }
}
