using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust;
    public float turnThrust;
    private float thrustForce;
    private float turnForce;
    public float Up;
    public float Down;
    public float Left;
    public float Right;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        thrustForce = Input.GetAxis("Vertical");
        turnForce = Input.GetAxis("Horizontal");

        Vector2 newPos = transform.position;
        if (transform.position.y > Up)
        {
            newPos.y = Down;
        }
        if (transform.position.y < Down)
        {
            newPos.y = Up;
        }
        if (transform.position.x > Right)
        {
            newPos.x = Left;
        }
        if (transform.position.x < Left)
        {
            newPos.x = Right;
        }
        transform.position = newPos;
    }

    void FixedUpdate()
    {
        rb.AddRelativeForce(Vector2.up * thrustForce);
        rb.AddTorque(-turnForce);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("asteroid"))
        {
            Destroy(gameObject);
        }
    }
}



    

