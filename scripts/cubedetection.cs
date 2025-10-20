using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var humanoide = collision.gameObject.GetComponent<HumanoideTypeIdentifier>();
        if (humanoide == null) return;

        if (humanoide.tipo == HumanoideTypeIdentifier.Tipo.Tipo1) // Guerrero
            EventManager.MiTipo1Colision(collision.gameObject);
        else if (humanoide.tipo == HumanoideTypeIdentifier.Tipo.Tipo2) // Lich
            EventManager.MiTipo2Colision(collision.gameObject);
    }
}
