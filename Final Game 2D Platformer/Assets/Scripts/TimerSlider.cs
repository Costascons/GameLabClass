using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerSlider : MonoBehaviour
{
    Slider TimeSlider;
    
    public Text wintext;
    public string levelToLoad;
    public float somenumber;

    // Use this for initialization
    void Start()
    {
        TimeSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {


        float val = TimeSlider.value;
        TimeSlider.value = val + Time.deltaTime + somenumber;

        if (TimeSlider.value == 0)
        {
            wintext.text = "";
        }
        else if (TimeSlider.value == 1050)
        {
            wintext.text = "Time Running Out!";
            SceneManager.LoadScene(levelToLoad);
        }
        
    }
}
