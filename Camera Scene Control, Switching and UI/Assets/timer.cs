using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    float timeTracker;
    Slider slidey;
    public Text wintext;

	// Use this for initialization
	void Start () {
        slidey = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        timeTracker = Time.time;
        slidey.value = timeTracker;

        if (slidey.value >= 10)
        {
            wintext.text = "You Lose!";
        }
	}
}
