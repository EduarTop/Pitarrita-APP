using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class CasillaInferiorIzquierda : MonoBehaviour
{
    private GameObject ficha;
    private bool hayFichaEncima = false;

    void Update()
    {
        if (hayFichaEncima)
        {
            MoverFichaALaEsquinaInferiorDerecha();
        }

        // Verifica si el jugador presiona un botón para sacar la ficha
        if (Input.GetKeyDown(KeyCode.Space) && hayFichaEncima)
        {
            SacarFicha();
        }
    }

    void MoverFichaALaEsquinaInferiorDerecha()
    {
        // Mueve la ficha hacia la esquina inferior derecha del objeto base
        Vector2 destino = new Vector2(transform.position.x + 0.2f, transform.position.y - 0.2f);
        ficha.transform.position = Vector2.MoveTowards(ficha.transform.position, destino, Time.deltaTime * 5f);
    }

    void SacarFicha()
    {
        // Desvincula la ficha del objeto base
        ficha.transform.parent = null;

        // Restablece la referencia al objeto ficha
        ficha = null;

        // Restablece la variable de detección de ficha encima
        hayFichaEncima = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entró tiene el tag "Ficha" o "FichaRoja"
        if ((other.CompareTag("Ficha") || other.CompareTag("FichaRoja")) && !hayFichaEncima)
        {
            // Almacena una referencia al objeto ficha
            ficha = other.gameObject;

            // Vincula la ficha al objeto base
            ficha.transform.parent = transform;

            // Actualiza la variable de detección de ficha encima
            hayFichaEncima = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Verifica si el objeto que salió tiene el tag "Ficha" o "FichaRoja"
        if (other.CompareTag("Ficha") || other.CompareTag("FichaRoja"))
        {
            // Restablece la referencia al objeto ficha
            ficha = null;

            // Restablece la variable de detección de ficha encima
            hayFichaEncima = false;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

