using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonNivel : MonoBehaviour
{
    public int nivel;
    public Button botonNivel;
    public Text txtNivel;

    void Start()
    {
        int nivelDelJugador = PlayerPrefs.GetInt("nivel", 1);
        botonNivel.interactable = (nivelDelJugador >= nivel);
        txtNivel.text = nivel.ToString("00");
        print(nivelDelJugador);
    }

    public void AbrirNivel()
    {
        SceneManager.LoadScene("Nivel" + nivel);
    }

}
