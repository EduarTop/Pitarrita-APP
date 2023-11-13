using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class IniciadorAlAzar : MonoBehaviour
{
    public GameObject objetoRojo;
    public GameObject objetoAzul;
    private bool objetoMostrado = false;

    void Start()
    {
        MostrarObjeto();
    }

    void MostrarObjeto()
    {
        if (!objetoMostrado)
        {
            GameObject objetoAparece = Random.Range(0, 2) == 0 ? objetoRojo : objetoAzul;
            objetoAparece.SetActive(true);
            objetoMostrado = true;
            Invoke("OcultarObjeto", 2f);
        }
    }

    void OcultarObjeto()
    {
        GameObject objetoAparece = objetoRojo.activeSelf ? objetoRojo : objetoAzul;
        objetoAparece.SetActive(false);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
