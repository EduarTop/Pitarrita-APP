using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaImpacto : MonoBehaviour
{
    public void CambiarEscena()
    {
        SceneManager.LoadScene("ImpactoSocial");
    }
}