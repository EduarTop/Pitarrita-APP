using UnityEngine;
using UnityEngine.Events;

public class RedireccionarFacebook : MonoBehaviour
{
    public string url = "https://www.facebook.com/AJugarPitarra?mibextid=ZbWKwL";
    public UnityEvent onButtonClick;

    public void AbrirPaginaDeFacebook()
    {
        onButtonClick.Invoke();
    }
}
