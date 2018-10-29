using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckpointScript : MonoBehaviour {
    public Sprite goFlag;
    public Sprite redFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;
    public Text wintext;
    public string levelToLoad;

    // Use this for initialization
    void Start () {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Player")
        {
            checkpointSpriteRenderer.sprite = goFlag;
            checkpointReached = true;
            wintext.text = "You Win!";
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
