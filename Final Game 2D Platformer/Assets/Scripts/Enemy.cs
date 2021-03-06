﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {
    private Transform target;

    public Transform Target
    {
        get
        {
            return target;
        }

        set
        {
            target = value;
        }
    }
    protected override void Update()
    {
        FollowTarget();
        base.Update();
    }
        


    
	
    private void FollowTarget()
    {
        if(target != null)
        {
            direction = (target.transform.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }else
        {
            direction = Vector2.zero;
        }
    }
}
