using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioManager : MonoBehaviour
{
    public void CargarJuego()
    {
        // Cargar la escena del juego
        SceneManager.LoadScene("JUEGOdePITARRA");
    }
}
