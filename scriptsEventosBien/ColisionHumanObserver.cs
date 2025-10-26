using UnityEngine;

public class ColisionHumanObserver : MonoBehaviour
{
    public ColisionHuman colision;
    public Transform escudo1;
    public Transform escudo2;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        colision.OnChoqueTipo1 += AddForceEscudo1;
        colision.OnChoqueTipo2 += AddForceEscudo2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AddForceEscudo1()
    {
        rb.AddForce((escudo1.transform.position - transform.position).normalized * 10, ForceMode.Impulse);
    }

    void AddForceEscudo2()
    {
        rb.AddForce((escudo2.transform.position - transform.position).normalized * 10, ForceMode.Impulse);
    }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("escudoTipo2"))
    {
        GetComponentInChildren<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
  }
}
