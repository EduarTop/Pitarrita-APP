using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public string sceneName = "JUEGOdePITARRA"; // Nombre de la escena que quieres cargar

    // Este método será llamado cuando se haga clic en el botón
    public void ReloadCurrentScene()
    {
        // Carga la escena con el nombre especificado
        SceneManager.LoadScene(sceneName);
    }
}
