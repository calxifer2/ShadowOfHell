using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float FuerzaDeJumping;
    public float velocity;
    public bool MDerecha;
    public bool MIzquierda;
    public bool EnPiso = true;

    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void caminar()
    {
        // Movement for mobile devices
        if (MIzquierda)
        {
            transform.Translate(-velocity * Time.deltaTime, 0, 0);
        }
        if (MDerecha)
        {
            transform.Translate(velocity * Time.deltaTime, 0, 0);
        }
    }

    private void Update()
    {
        caminar();

        // Movement for PC
        MDerecha = (Input.GetAxis("Horizontal") > 0.1f);
        MIzquierda = (Input.GetAxis("Horizontal") < -0.1f);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jumping();
        }
    }

    public void Jumping()
    {
        if (EnPiso)
        {
            rb2D.AddForce(Vector2.up * FuerzaDeJumping, ForceMode2D.Impulse);
            EnPiso = false; 
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        EnPiso = true; 
    }
}
