using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager control;
    public bool doorway1Unlocked;
    public bool doorway2Unlocked;
    public bool doorway3Unlocked;
    public bool doorway4Unlocked;
    public int keyCount;

    



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
    void Start()
    {
        doorway1Unlocked = false;
        doorway2Unlocked = false;
        doorway3Unlocked = false;
        doorway4Unlocked = false;
        keyCount = 0;
         }

}
