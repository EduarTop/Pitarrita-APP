using System.Diagnostics;
using UnityEngine;
using System.Collections.Generic;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class FichaDetector : MonoBehaviour
{
    public int fichasNecesarias = 3;
    private HashSet<Collider2D> fichasEntradas = new HashSet<Collider2D>();
    private bool sonidoReproducido = false;
    public AudioSource audioSource;
    private string fichaTag = ""; // Almacena el tag de la ficha actual

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (fichasEntradas.Count < fichasNecesarias && !sonidoReproducido)
        {
            if (fichasEntradas.Count == 0)
            {
                fichaTag = other.tag; // Almacena el tag de la primera ficha
            }

            if (other.CompareTag(fichaTag))
            {
                fichasEntradas.Add(other);

                if (fichasEntradas.Count == fichasNecesarias)
                {
                    ReproducirSonidoConRetraso();
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (fichasEntradas.Contains(other) && other.CompareTag(fichaTag))
        {
            fichasEntradas.Remove(other);

            if (sonidoReproducido && fichasEntradas.Count < fichasNecesarias)
            {
                sonidoReproducido = false;
                DetenerSonido();
            }
        }
    }

    void ReproducirSonidoConRetraso()
    {
        sonidoReproducido = true;
        audioSource.Play(); // Reproduce el sonido inmediatamente
    }

    void DetenerSonido()
    {
        audioSource.Stop();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}