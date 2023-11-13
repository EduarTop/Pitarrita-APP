using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public string sceneName = "JUEGOdePITARRA"; // Nombre de la escena que quieres cargar

    // Este m�todo ser� llamado cuando se haga clic en el bot�n
    public void ReloadCurrentScene()
    {
        // Carga la escena con el nombre especificado
        SceneManager.LoadScene(sceneName);
    }
}
