using TMPro;
using UnityEngine;

public class UIPuntuacion : MonoBehaviour
{
    CollectShields collectShields;
    public TMP_Text text;
    public TMP_Text textoRecompensa;
    int recompensa = 0;
    int puntuacionPrevia = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collectShields = GetComponent<CollectShields>();
        collectShields.OnCambio += Muestra;
        collectShields.OnCambio += Recompensa;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Muestra(int puntuacion)
    {
        text.text = "Puntuación: " + puntuacion;
    }
    
    void Recompensa(int puntuacion)
    {
        recompensa += puntuacion - puntuacionPrevia;
        puntuacionPrevia = puntuacion;
        if (recompensa >= 100)
        {
            recompensa -= 100;
            textoRecompensa.text = "RECOMPENSA OBTENIDA";
        } else
        {
            textoRecompensa.text = "";
        }
    }
}
