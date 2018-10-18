using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characMovement : MonoBehaviour
{
    public float speed = 3f;
    public float jumpSpeed = 10f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
  
    
    

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
       
        movement = Input.GetAxis("Horizontal");
        
        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (movement < 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(-1f, 1f);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    }
}