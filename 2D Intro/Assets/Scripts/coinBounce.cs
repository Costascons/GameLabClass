using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float speed = 10f;
    float height = 0.5f;
	// Update is called once per frame
	void Update () {
        //transform.Rotate(0, 0, Time.deltaTime * 100);
        //transform.Translate(Vector2.up * (Mathf.Sin(Time.time*10)/80));
        Vector2 pos = transform.position;
        //Multiplying inside the brackets by speed will increase how fast it moves.
        float newY = Mathf.Sin(Time.time * speed) * 0.25f;
        transform.position = new Vector2(pos.x, newY);

    }
}
