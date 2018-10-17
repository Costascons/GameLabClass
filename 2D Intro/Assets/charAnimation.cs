using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charAnimation : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite lookRight;
    public Sprite lookLeft;
    public Sprite lookCenter;
    public float moveSpeed = 0.07f;

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //if right
        //GetKey allows for a longer duration for the character to turn rather than
        //the GetKeyDown which turns too fast.
        if (Input.GetKey(KeyCode.W))
        {
            sr.sprite = lookRight;
            //rb.AddForce(transform.right * moveSpeed, ForceMode2D.Impulse);
        }
        //if left
        else if (Input.GetKey(KeyCode.S))
        {
            sr.sprite = lookLeft;
            //rb.AddForce(transform.right * -moveSpeed, ForceMode2D.Impulse);
        }
        
        else
        {
            sr.sprite = lookCenter;
        }

    }
}