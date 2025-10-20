using UnityEngine;

public class HumanoideAccion : MonoBehaviour
{
    public Event eventoReferencia;        // Asigna aquí el objeto que lanza el evento
    public Transform escudoObjetivo;      // Adónde se teletransportan los tipo1
    public Transform orientacionObjetivo; // Adónde miran los tipo2

    private HumanoideTypeIdentifier tipoId;

    private void Awake()
    {
        tipoId = GetComponent<HumanoideTypeIdentifier>();
    }

    private void OnEnable()
    {
        if (eventoReferencia != null)
            eventoReferencia.OnMiEvento += Reaccionar;
    }

    private void OnDisable()
    {
        if (eventoReferencia != null)
            eventoReferencia.OnMiEvento -= Reaccionar;
    }

    private void Reaccionar()
    {
        if (tipoId == null) return;

        if (tipoId.tipo == HumanoideTypeIdentifier.Tipo.Tipo1)
        {
            // Teletransportar al escudo
            if (escudoObjetivo != null)
            {
                Debug.Log($"{name} (Tipo1) se teletransporta al escudo.");
                transform.position = escudoObjetivo.position;
            }
        }
        else if (tipoId.tipo == HumanoideTypeIdentifier.Tipo.Tipo2)
        {
            // Orientar hacia el objetivo
            if (orientacionObjetivo != null)
            {
                Vector3 direccion = orientacionObjetivo.position - transform.position;
                direccion.y = 0;
                if (direccion.sqrMagnitude > 0.01f)
                    transform.rotation = Quaternion.LookRotation(direccion);
                Debug.Log($"{name} (Tipo2) se orienta hacia el objetivo.");
            }
        }
    }
}
