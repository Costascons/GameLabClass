using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleScript : MonoBehaviour {
    public Slider EnergySlider;
    public Slider MoneySlider;
    public int itemEnergy;
    public int itemPrice;
    public Text wintext;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}//Can replace 'other' with tag or name of objects being collided with.
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            float value1 = EnergySlider.value;
            EnergySlider.value += itemEnergy;
            float value2 = MoneySlider.value;
            MoneySlider.value += itemPrice;
            Destroy(gameObject);

        }
       
    }
    
}
