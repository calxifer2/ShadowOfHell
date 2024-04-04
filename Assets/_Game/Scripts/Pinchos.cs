using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour
{

    public Animator anim;
    public Movements movimiento;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            anim.SetBool("Die", true);
            //movimiento.DejarMover();
            enabled = false;
            Invoke("Reiniciar", 2);
            Debug.Log("Pinchooos");
        }
    }

    void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }

}
