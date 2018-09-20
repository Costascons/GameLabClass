using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{

    public float speed;
    public float moveforce;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * moveforce * 2, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * moveforce * 2, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * moveforce * 2, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.back * moveforce * 2, ForceMode.Impulse);
        }
    }
}
