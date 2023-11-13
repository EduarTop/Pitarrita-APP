using UnityEngine;

public class MovimientoFicha : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        isDragging = true;
    }

    void OnMouseUp() => isDragging = false;

    void Update()
    {
        if (isDragging)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }
}

