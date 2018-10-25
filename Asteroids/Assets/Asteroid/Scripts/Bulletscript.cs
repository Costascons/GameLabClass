﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour {
    public float speed = 20f;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }
    }
}
