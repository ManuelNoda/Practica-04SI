using UnityEngine;

public class CollectShields : MonoBehaviour
{
    public delegate void cambiaPuntuacion(int p);
    public event cambiaPuntuacion OnCambio;
    int puntuacion = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("escudoTipo1"))
        {
            puntuacion += 5;
            Debug.Log(puntuacion);
            OnCambio(puntuacion);
            other.gameObject.SetActive(false);
        } else if (other.gameObject.CompareTag("escudoTipo2"))
        {
            puntuacion += 10;
            Debug.Log(puntuacion);
            OnCambio(puntuacion);
            other.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("escudoTipo1"))
        {
            puntuacion += 5;
            Debug.Log(puntuacion);
            OnCambio(puntuacion);
            collision.gameObject.SetActive(false);
        } else if (collision.gameObject.CompareTag("escudoTipo2"))
        {
            puntuacion += 10;
            Debug.Log(puntuacion);
            OnCambio(puntuacion);
            collision.gameObject.SetActive(false);
        }
    }
}
