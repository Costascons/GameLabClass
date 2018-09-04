using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator2 : MonoBehaviour {

	// Update is called once per frame
	void Update () 
        {
            transform.Rotate(new Vector3(45, 55, 70) * Time.deltaTime);
        }
    }


