using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{


    public void StartGame(string levelName)
    {
        SceneManager.LoadScene(levelName);
        GameManager.control.keyCount = 0;
        GameManager.control.doorway1Unlocked = false;
        GameManager.control.doorway2Unlocked = false;
        GameManager.control.doorway3Unlocked = false;
        GameManager.control.doorway4Unlocked = false;

    }
}
