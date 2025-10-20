using UnityEngine;

public class RecolectarEscudo : MonoBehaviour
{
    public enum TipoEscudo { Tipo1, Tipo2 }
    public TipoEscudo tipoEscudo;

    public PuntuacionUI puntuacionUI; // Referencia al script de UI

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube")) 
        {
            int puntos = (tipoEscudo == TipoEscudo.Tipo1) ? 5 : 100; // Tipo2 da 100 puntos

            if (puntuacionUI != null)
                puntuacionUI.SumarPuntos(puntos);
            else
                Debug.LogWarning("No hay referencia al script PuntuacionUI en el escudo.");

            Debug.Log($"Escudo {tipoEscudo} recogido. +{puntos} puntos.");

            Destroy(gameObject); // Destruye el escudo
        }
    }
}

