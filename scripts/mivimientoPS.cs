using UnityEngine;

public class movimientoPS : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movex = 0f;
        float movez = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            movex = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movez = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movex = 1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            movez = 1f;
        }

        Vector3 movimiento = new Vector3(movex, 0, movez).normalized * speed;
        Vector3 newposition = transform.position + movimiento * Time.deltaTime;
        rb.MovePosition(newposition);
    }
}
