using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class asteroidManager : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public GameObject asteroid;
    public GameObject Player;
    float timer = 0;

    GameObject[] asteroids;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 0.08)
        {

            GameObject clone = Instantiate(asteroid, (new Vector2(Random.Range(3f, 300f), 10f)), Quaternion.identity);
            clone.transform.localScale = new Vector2(Random.Range(0.5f, 3f), 3f);
            timer = 0;
        }
        asteroids = GameObject.FindGameObjectsWithTag("asteroid");

        foreach (GameObject asteroid in asteroids)
        {
            asteroid.transform.localPosition = new Vector2(asteroid.transform.localPosition.y, asteroid.transform.localPosition.x - 0.1f);
            {
                if (asteroid.transform.localPosition.x < -6)
                {
                    Destroy(asteroid);
                }

            }


        }

    }
     
}
