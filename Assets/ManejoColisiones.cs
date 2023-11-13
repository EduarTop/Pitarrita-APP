using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejoColisiones : MonoBehaviour
{
    private int fichasAzulesColisionadas = 0;
    private int fichasRojasColisionadas = 0;
    private bool felicidadesMostrado = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Ficha"))
        {
            fichasAzulesColisionadas++;
        }
        else if (collider.CompareTag("FichaRoja"))
        {
            fichasRojasColisionadas++;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Ficha"))
        {
            fichasAzulesColisionadas--;
        }
        else if (collider.CompareTag("FichaRoja"))
        {
            fichasRojasColisionadas--;
        }
    }

    void Update()
    {
        if (!felicidadesMostrado && (fichasAzulesColisionadas >= 10 || fichasRojasColisionadas >= 10))
        {
            felicidadesMostrado = true;
            if (fichasAzulesColisionadas >= 10)
            {
                Debug.Log("¡Felicidades! Ganador Rojo");
                SceneManager.LoadScene("GanadorRojo");
            }
            else
            {
                Debug.Log("¡Felicidades! Ganador Azul");
                SceneManager.LoadScene("GanadorAzul");
            }
        }
    }
}
