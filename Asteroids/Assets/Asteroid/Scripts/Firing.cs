using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public Transform gunEnd;
    public GameObject bullet;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    } 
    void Shoot()
    {
        Instantiate(bullet, gunEnd.position, gunEnd.rotation);
    }
}