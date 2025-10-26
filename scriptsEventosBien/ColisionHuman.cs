using UnityEngine;

public class ColisionHuman : MonoBehaviour
{
    public delegate void colision();
    public event colision OnChoqueTipo1;
    public event colision OnChoqueTipo2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("tipo1"))
    {
        OnChoqueTipo2();
    } else if (collision.gameObject.CompareTag("tipo2"))
    {
        OnChoqueTipo1();
    }
  }
}
