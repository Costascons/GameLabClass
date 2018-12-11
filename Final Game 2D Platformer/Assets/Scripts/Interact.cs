using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "key1")
        {
            GameManager.control.keyCount++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "key2")
        {
            GameManager.control.keyCount++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "key3")
        {
            GameManager.control.keyCount++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "key4")
        {
            GameManager.control.keyCount++;
            Destroy(other.gameObject);
        }

       
        if (other.gameObject.tag == "key1")
        {

            GameManager.control.doorway1Unlocked = true;
            
        }
        if (other.gameObject.tag == "key2")
        {

            GameManager.control.doorway2Unlocked = true;

        }
        if (other.gameObject.tag == "key3")
        {

            GameManager.control.doorway3Unlocked = true;

        }
        if (other.gameObject.tag == "key4")
        {

            GameManager.control.doorway4Unlocked = true;

        }
    }
}