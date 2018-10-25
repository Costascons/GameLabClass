﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour {
    public Sprite goFlag;
    public Sprite redFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;

	// Use this for initialization
	void Start () {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Player")
        {
            checkpointSpriteRenderer.sprite = goFlag;
            checkpointReached = true;
        } 
    }
}