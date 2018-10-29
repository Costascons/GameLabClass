using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class slideControl : MonoBehaviour
{
    //float timeTracker;
    Slider EnergySlider;
    Slider MoneySlider;
    public Text wintext;
    public string levelToLoad;
    public float somenumber;

    // Use this for initialization
    void Start()
    {
        EnergySlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
         GetComponent<CollectibleScript>();
       
        
        float val = EnergySlider.value;
        EnergySlider.value = val + Time.deltaTime + somenumber;

        if (EnergySlider.value == 0)
        {
            wintext.text = "";
        }
        else if (EnergySlider.value == 1000)
        {
            wintext.text = "You Lose!";
            SceneManager.LoadScene(levelToLoad);
        }
       
    }
}
