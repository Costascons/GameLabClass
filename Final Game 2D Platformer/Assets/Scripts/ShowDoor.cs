using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDoor : MonoBehaviour
{
    public GameObject Doorway1Gate;
    public GameObject Doorway2Gate;
    public GameObject Doorway3Gate;
    public GameObject Doorway4Gate;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    // Use this for initialization
    void Start()
    {
        Doorway1Gate.SetActive(GameManager.control.doorway1Unlocked);
        Doorway2Gate.SetActive(GameManager.control.doorway2Unlocked);
        Doorway3Gate.SetActive(GameManager.control.doorway3Unlocked);
        Doorway4Gate.SetActive(GameManager.control.doorway4Unlocked);
        

        if (GameManager.control.keyCount == 1)
        {
            key1.SetActive(false);
        }
        if (GameManager.control.keyCount == 2)
        {
            key2.SetActive(false);
        }
        if (GameManager.control.keyCount == 3)
        {
            key3.SetActive(false);
        }
        if (GameManager.control.keyCount == 4)
        {
            key4.SetActive(false);
        }

    }


}
