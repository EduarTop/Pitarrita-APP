using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("INICIO"); // Reemplazamos "NombreDeTuEscenaDelMenu" con el nombre de tu escena del menú, que es "INICIO" en este caso
    }
}
