using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Slider MoneySlider;
    private LevelMaster gameLevelMaster;
    public int score = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }//Can replace 'other' with tag or name of objects being collided with.
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            float value = MoneySlider.value;
            MoneySlider.value = MoneySlider.value -= 10;
            Destroy(this.gameObject);
        }
    }
}
