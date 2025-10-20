using UnityEngine;

public class Event : MonoBehaviour
{
    public delegate void Mensaje();
    public event Mensaje OnMiEvento;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Cubo colisionó con el cilindro. Enviando evento.");
            OnMiEvento?.Invoke();
        }
    }

    private void OnDestroy()
    {
        // 🔹 Limpia todas las suscripciones al destruir el objeto
        OnMiEvento = null;
    }
}
