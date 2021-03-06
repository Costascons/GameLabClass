﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour {
    Slider MoneySlider;
    public Text wintext;
    public string levelToLoad;

    // Use this for initialization
    void Start () {
        MoneySlider = GetComponent<Slider>();
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<CollectibleScript>();

        if (MoneySlider.value == 0)
        {
            wintext.text = "";
        }
        else if (MoneySlider.value == 100)
        {
            wintext.text = "You Lose!";
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
