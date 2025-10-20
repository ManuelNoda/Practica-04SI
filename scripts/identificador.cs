using UnityEngine;

public class HumanoideTypeIdentifier : MonoBehaviour
{
    public enum Tipo { Tipo1, Tipo2 }
    public Tipo tipo;

    private void Awake()
    {
        // Asignar tipo automáticamente según el tag
        if (CompareTag("tipo1"))
            tipo = Tipo.Tipo1; // Guerrero
        else if (CompareTag("tipo2"))
            tipo = Tipo.Tipo2; // Lich
        else
            Debug.LogWarning($"{name} no tiene tag tipo1 o tipo2");
    }
}
