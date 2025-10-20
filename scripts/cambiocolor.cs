using UnityEngine;

public class EscudoColorChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var tipoId = other.GetComponent<HumanoideTypeIdentifier>();
        if (tipoId == null) return;

        // Buscar Renderer incluso si está en un child
        var rend = GetComponent<Renderer>();
        if (rend == null)
            rend = GetComponentInChildren<Renderer>();
        if (rend == null) return;

        // Crear instancia de material para este escudo
        rend.material = new Material(rend.material);

        if (tipoId.tipo == HumanoideTypeIdentifier.Tipo.Tipo2) // Lich
            rend.material.color = Color.red;
        else if (tipoId.tipo == HumanoideTypeIdentifier.Tipo.Tipo1) // Guerrero
            rend.material.color = Color.blue;
    }
}
