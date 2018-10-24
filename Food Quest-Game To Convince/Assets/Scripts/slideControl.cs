using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class slideControl : MonoBehaviour
{
    float timeTracker;
    Slider EnergySlider;
    Slider MoneySlider;
    public Text wintext;

    // Use this for initialization
    void Start()
    {
        EnergySlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
         GetComponent<CollectibleScript>();
       
        timeTracker = Time.time;
        EnergySlider.value = timeTracker;

        if (EnergySlider.value == 0)
        {
            wintext.text = "";
        }
        else if (EnergySlider.value == 20)
        {
            wintext.text = "You Lose!";
        }
       
    }
}
