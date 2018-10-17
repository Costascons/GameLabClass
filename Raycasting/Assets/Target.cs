using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour {
    public float health = 50f;
    public int scoreValue = 10;
    public Text ScoreText;
    
    private int score= 0;

     void Start()
    {
     
    }


    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        ScoreManager.score += scoreValue;
        Destroy(gameObject);
    }

    
}
