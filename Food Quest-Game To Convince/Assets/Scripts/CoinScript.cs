﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {
    public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}//Can replace 'other' with tag or name of objects being collided with.
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        Destroy(gameObject);
        //score = score + 1;
        //score = score++;
        score += 5;
        Debug.Log("Score: " +score);
    }
}