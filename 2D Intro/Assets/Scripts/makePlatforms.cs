using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePlatforms : MonoBehaviour
{
    public GameObject platform;
    float timer = 0;

    GameObject[] platforms;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;
        if (timer >= 1.5)
        {
            //Instantiate (What it is, where it is, what its rotation is)
            GameObject clone = Instantiate(platform, (new Vector2(Random.Range(-10f, 10f), 6f)), Quaternion.identity);
            clone.transform.localScale = new Vector2(Random.Range(2f, 8f), 1f);
            timer = 0;
        }//Tags allow you to perform an action on multiple objects.
        platforms = GameObject.FindGameObjectsWithTag("platform");

        foreach (GameObject platform in platforms)
        {
            platform.transform.localPosition = new Vector2(platform.transform.localPosition.x, platform.transform.localPosition.y - 0.08f);
            {
                if (platform.transform.localPosition.y < -6)
                {
                    Destroy(platform);
                }

            }


        }
    }
}

