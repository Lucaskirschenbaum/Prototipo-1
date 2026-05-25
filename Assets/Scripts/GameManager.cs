using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int maxScore = 5;
    public float timeRemaining = 60f;

    private UIManager uiManager;
    private bool gameOver = false;

    void Awake()
    {
        instance = this;
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (gameOver) return;

        timeRemaining -= Time.deltaTime;
        uiManager.UpdateTime(timeRemaining);

        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            gameOver = true;
            Debug.Log("Loss");
        }
    }

    public void AddScore()
    {
        if (gameOver) return;

        score++;
        uiManager.UpdateScore(score);

        if (score >= maxScore)
        {
            gameOver = true;
            Debug.Log("Win");
        }
    }
}

