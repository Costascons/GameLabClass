using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;


public class colliderPlayer : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    public Vector2 respawnPoint;
    private Rigidbody rb;
    private int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collider"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.tag == "Fall Detector")
        {
            transform.position = respawnPoint;
        }
        if(other.tag == "Respawn")
        {
            respawnPoint = other.transform.position;
        }
    }
    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 4)
        {
            winText.text = "You Win!";
        }
    }
    
}
