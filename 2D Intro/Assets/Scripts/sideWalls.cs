using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideWalls : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "ExplosionBall")
        {
            string wallName = transform.name;
            gameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
           
        }
        Debug.Log("Collider");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
