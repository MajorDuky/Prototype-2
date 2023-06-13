using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesAndScoreCounter : MonoBehaviour
{
    public int lives;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        score = 0;
        Debug.Log("Lives Start : " + lives);
        Debug.Log("Score Start : " + score);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score : " + score);
    }

    public void DecreaseLives()
    {
        lives -= 1;
        Debug.Log("Lives : " + lives);
    }

    public void GameOverState()
    {
        Debug.Log("Game Over !");
    }
}
