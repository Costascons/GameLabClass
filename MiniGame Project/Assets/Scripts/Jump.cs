using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//code found in video tutorial on how to perform a jump
//https://www.youtube.com/watch?reload=9&v=oikSPEfIk-Q
public class Jump : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(3f, 10f, 3f);
                onGround = false;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}