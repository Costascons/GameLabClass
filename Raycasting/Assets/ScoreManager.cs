using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
    public static int score;
    public Text RestartText;


    Text text;

    void Start()
    {
        
        RestartText.text = "";
    }
	void Awake () {
        text = GetComponent <Text> ();
        score = 0;
	}

    void Update() {
        text.text = "Score:" + score;
        if (score == 75)
        {
            SceneManager.LoadScene("Box Smasher");
            RestartText.text = "Good Job!"; }
    }

    
}
