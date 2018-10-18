using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleGenerator : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public GameObject platform;
    float timer = 0;

    GameObject[] platforms;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 0.05)
        {
            
            GameObject clone = Instantiate(platform, (new Vector2(Random.Range(3f, 300f), 10f)), Quaternion.identity);
            clone.transform.localScale = new Vector2(Random.Range(0.5f, 1f), 0.5f);
            timer = 0;
        }
        platforms = GameObject.FindGameObjectsWithTag("platform");

        foreach (GameObject platform in platforms)
        {
            platform.transform.localPosition = new Vector2(platform.transform.localPosition.y, platform.transform.localPosition.x - 0.1f);
            {
                if (platform.transform.localPosition.x < -6)
                {
                    Destroy(platform);
                }

            }


        }
        
    }
}
