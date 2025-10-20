using UnityEngine;
using System.Collections;

public class HumanoideMover : MonoBehaviour
{
    public Transform escudoObjetivo;
    public float speed = 5f;

    private HumanoideTypeIdentifier tipoId;

    private void Awake()
    {
        tipoId = GetComponent<HumanoideTypeIdentifier>();
    }

    private void OnEnable()
    {
        EventManager.OnMiTipo2ColisionConCubo += MoverSiTipo1;
        EventManager.OnMiTipo1ColisionConCubo += MoverSiTipo2;
    }

    private void OnDisable()
    {
        EventManager.OnMiTipo2ColisionConCubo -= MoverSiTipo1;
        EventManager.OnMiTipo1ColisionConCubo -= MoverSiTipo2;
    }

    void MoverSiTipo1(GameObject tipo2) // Los Tipo1 se mueven si colisiona un Tipo2
    {
        if (tipoId.tipo == HumanoideTypeIdentifier.Tipo.Tipo1 && escudoObjetivo != null)
            StartCoroutine(MoverHacia(escudoObjetivo.position));
    }

    void MoverSiTipo2(GameObject tipo1) // Los Tipo2 se mueven si colisiona un Tipo1
    {
        if (tipoId.tipo == HumanoideTypeIdentifier.Tipo.Tipo2 && escudoObjetivo != null)
            StartCoroutine(MoverHacia(escudoObjetivo.position));
    }

    IEnumerator MoverHacia(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, speed * Time.deltaTime);
            yield return null;
        }
    }
}
