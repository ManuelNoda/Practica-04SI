using TMPro;
using UnityEngine;

public class PuntuacionUI : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;   // Texto que muestra la puntuación
    public TextMeshProUGUI textoRecompensa;   // Texto que aparece al obtener la recompensa
    private int puntuacionTotal = 0;
    private int ultimaRecompensa = 0;

    // Llamado por RecolectarEscudo
    public void SumarPuntos(int puntos)
    {
        puntuacionTotal += puntos;
        ActualizarTexto();
        RevisarRecompensa();
    }

    private void ActualizarTexto()
    {
        if (textoPuntuacion != null)
            textoPuntuacion.text = $"Puntuación: {puntuacionTotal}";
    }

    private void RevisarRecompensa()
    {
        int siguienteRecompensa = (puntuacionTotal / 100) * 100;
        if (siguienteRecompensa > 0 && siguienteRecompensa > ultimaRecompensa)
        {
            // Mostrar la recompensa
            if (textoRecompensa != null)
            {
                
                textoRecompensa.gameObject.SetActive(true);
                Invoke(nameof(OcultarRecompensa), 6f); // Se oculta tras 2 segundos
            }

            ultimaRecompensa = siguienteRecompensa;
        }
    }

    private void OcultarRecompensa()
    {
        if (textoRecompensa != null)
            textoRecompensa.gameObject.SetActive(false);
    }
}
