using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action<GameObject> OnMiTipo1ColisionConCubo; // Guerreros
    public static event Action<GameObject> OnMiTipo2ColisionConCubo; // Lich

    public static void MiTipo1Colision(GameObject tipo1)
    {
        OnMiTipo1ColisionConCubo?.Invoke(tipo1);
    }

    public static void MiTipo2Colision(GameObject tipo2)
    {
        OnMiTipo2ColisionConCubo?.Invoke(tipo2);
    }
}
