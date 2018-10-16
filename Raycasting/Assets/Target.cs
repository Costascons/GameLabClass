using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour {
    public float health = 50f;
    public int scoreValue = 10;
    public Text ScoreText;
    public float restartDelay = 5f;
    public string scene;
   

    Animator anim;
    float restartTimer;
    private int score= 0;

     void Start()
    {
        EndGame(); 
    }



    void Awake()
    {
        anim = GetComponent<Animator>();

    }

    void Update()
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

    void EndGame()
    {
        ScoreText.text = "ScoreText: " + ScoreText.ToString();
        if (score >= 10)
        {
            anim.SetBool("GameOver", true);
            restartTimer += Time.deltaTime;


            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
    
}
