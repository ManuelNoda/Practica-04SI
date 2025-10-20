using UnityEngine;
using System.Collections;

public class Subcripcion : MonoBehaviour
{
    public enum SphereType { Tipo1, Tipo2 }
    public SphereType sphereType;

    public Transform targetSphere;  // Para Tipo1
    public Transform cylinder;      // Para Tipo2
    public float speed = 5f;

    public Event notificador;

    private void Awake()
    {
        if (gameObject.CompareTag("tipo1"))
        {
            sphereType = SphereType.Tipo1;
        }
        else if (gameObject.CompareTag("tipo2"))
        {
            sphereType = SphereType.Tipo2;
        }
        else
        {
            Debug.LogWarning("La esfera no tiene tag 'tipo1' o 'tipo2'");
        }
    }

    private void OnEnable()
    {
        if (notificador != null)
        {
            Debug.Log($"{name} se SUSCRIBE al evento.");
            notificador.OnMiEvento += MoveSphere;
        }
        else
        {
            Debug.LogWarning($"{name} no tiene asignado el notificador.");
        }
    }

    private void OnDisable()
    {
        if (notificador != null)
        {
            Debug.Log($"{name} se DESUSCRIBE (OnDisable).");
            notificador.OnMiEvento -= MoveSphere;
        }
    }

    private void OnDestroy()
    {
        if (notificador != null)
        {
            Debug.Log($"{name} se DESUSCRIBE (OnDestroy).");
            notificador.OnMiEvento -= MoveSphere;
        }
    }

    void MoveSphere()
    {
        StopAllCoroutines();

        if (sphereType == SphereType.Tipo1 && targetSphere != null)
        {
            StartCoroutine(MoveToTarget(targetSphere.position));
        }
        else if (sphereType == SphereType.Tipo2 && cylinder != null)
        {
            StartCoroutine(MoveToTarget(cylinder.position));
        }
    }

    IEnumerator MoveToTarget(Vector3 destination)
    {
        while (Vector3.Distance(transform.position, destination) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }
    }
}
