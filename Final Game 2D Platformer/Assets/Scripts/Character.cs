﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {
    [SerializeField]
    protected float speed;
    private Animator animator;
    protected Vector2 direction;
    private Rigidbody2D myRigidbody;
    
    public bool IsMoving
    {
        get
        {
            return direction.x != 0 || direction.y != 0;
        }
    }

    protected virtual void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	
	protected virtual void Update () {
        HandleLayers();
	}

    private void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        myRigidbody.velocity = direction.normalized * speed; 
        
    }

    public void HandleLayers()
    {
        if (IsMoving)
        {
            
            ActivateLayer("WalkLayer");
            animator.SetFloat("x", direction.x);
            animator.SetFloat("y", direction.y);
        }
        else
        {
            ActivateLayer("IdleLayer");
        }
    }

    public void ActivateLayer(string layerName)
    {
        for (int i = 0; i < animator.layerCount; i++)
        {
            animator.SetLayerWeight(i, 0);
        }
        animator.SetLayerWeight(animator.GetLayerIndex(layerName), 1);
    }
}
