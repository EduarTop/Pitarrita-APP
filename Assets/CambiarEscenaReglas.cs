using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaReglas : MonoBehaviour
{
    public void CambiarEscena()
    {
        SceneManager.LoadScene("ReglasDelJuego");
    }
}
