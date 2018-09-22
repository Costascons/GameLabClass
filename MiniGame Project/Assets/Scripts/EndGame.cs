using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}