using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCollected : MonoBehaviour
{

    public Image  key1, key2, key3, key4;
    // Use this for initialization
    void Start()
    {
        key1.enabled = false;
        key2.enabled = false;
        key3.enabled = false;
        key4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.control.keyCount >= 1)
        {
            key1.enabled = true;
        }
        if (GameManager.control.keyCount >= 2)
        {
            key2.enabled = true;
        }
        if (GameManager.control.keyCount >= 3)
        {
            key3.enabled = true;

        }
        if (GameManager.control.keyCount >= 4)
        {
            key4.enabled = true;

        }

    }
}
