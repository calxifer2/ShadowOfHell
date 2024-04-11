using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovementsNivel12 : MonoBehaviour
{
    public float FuerzaDeJumping;
    public float velocity;
    public bool MDerecha;
    public bool MIzquierda;
    public bool EnPiso = true;
    public Transform graficos;

    public Animator anim;

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
            graficos.transform.localScale=new Vector3(-.34f,.34f,.34f);
        }
        if (MDerecha)
        {
            transform.Translate(velocity * Time.deltaTime, 0, 0);
            graficos.transform.localScale = new Vector3(.34f, .34f, .34f);
        }

        anim.SetBool("Run",MIzquierda || MDerecha);

    }

    private void Update()
    {
        caminar();

        // Movement for PC
        //MDerecha = (Input.GetAxis("Horizontal") > 0.1f);
        //MIzquierda = (Input.GetAxis("Horizontal") < -0.1f);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jumping();
        }
    }

    public void MoverDerecha()
    {
        if (Time.timeScale == 0) return ;
        MDerecha = true;
    }

    public void MoverIzquierda()
    {
        if (Time.timeScale == 0) return;
        MIzquierda = true;
    }

    public void DejarMover()
    {
        MDerecha = false;
        MIzquierda = false;
    }

    public InvertirGravedadJugador invertirGravedad;
    public void Jumping()
    {
        // Verifica si el jugador está en el suelo
        if (EnPiso)
        {
            // Llama al nuevo script para invertir la gravedad del jugador
            invertirGravedad.Invertir();

            // Establece que el jugador ya no está en el suelo
            EnPiso = true;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        EnPiso = true; 
    }

}
