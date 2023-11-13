using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaOrigen : MonoBehaviour
{
    public void CambiarEscena()
    {
        SceneManager.LoadScene("OrigenPitarra");
    }
}