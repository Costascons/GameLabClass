using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class gameControl : MonoBehaviour
{


    public static gameControl control;

    public float points;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(20, 50, 110, 40), "Points:" + points);
    }

}

