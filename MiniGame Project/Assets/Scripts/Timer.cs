using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//Timer code example found on https://www.youtube.com/watch?v=x-C95TuQtf0 
public class Timer : MonoBehaviour {
    public Text timerText;
    private float startTime;
    //private bool in order to end timer. 
    private bool finished = false;
    // Use this for initialization
	void Start () {
        //Time.time gives the time once the game begins.
        startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (finished) return;
        //Declare variable of when time will start.
        //Gives the amount of time since the timer has started.
        float t = Time.time - startTime;
        //Use string in order to create text for text object within Unity.
        //t/60 gives the amount of seconds divided by 60, while int function will remove decimals,
        //giving only the minutes.
        string minutes = ((int)t / 60).ToString();
        //f2 defines that only two decimals (floats) be shown in the timer, to remove all the number clutter.
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
		
	}
    public void Finished()
    {
        finished = true;
        timerText.color = Color.red;
        
    }
}
