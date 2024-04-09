using UnityEngine;
using UnityEngine.SceneManagement;

public class Armagedon : MonoBehaviour
{

    public int nivel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PasarNivel();
        }
    }

    void PasarNivel()
    {
        if (PlayerPrefs.GetInt("nivel") == nivel)
        {
            PlayerPrefs.SetInt("nivel", nivel + 1);
        }
        SceneManager.LoadScene("MenuNiveles");
    }
}
