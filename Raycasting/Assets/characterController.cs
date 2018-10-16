using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

    public float InputDelay = .01f;
    public float forwardVel = 12f;
    public float rotateVel = 100f;

    Quaternion targetRotation;
    Rigidbody rb;
    float forwardInput, turnInput;

    public Quaternion TargetRotation
    {
        get { return targetRotation; }
    }

    private void Start()
    {
        targetRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
        forwardInput = turnInput = 0;
    }

    void GetInput()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }

     void Update()
    {
        GetInput();
        Turn();
    }
     void FixedUpdate()
    {
        Run();
    }
    void Run()
    {
        if (Mathf.Abs(forwardInput) > InputDelay)
        {
            rb.velocity = transform.forward * forwardInput * forwardVel;
        }else
        {
            rb.velocity = Vector3.zero;
        }
    }
    void Turn()
    {
        if (Mathf.Abs(turnInput)> InputDelay)
        {
            targetRotation *= Quaternion.AngleAxis(rotateVel * turnInput * Time.deltaTime, Vector3.up);
        }
        transform.rotation = targetRotation;
    }
        
}
