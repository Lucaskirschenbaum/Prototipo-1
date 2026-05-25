using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txt_Score;
    public TextMeshProUGUI txt_Time;

    void Start()   
{
    UpdateScore(0);
    UpdateTime(GameManager.instance.timeRemaining);
}
    

    public void UpdateScore(int score)
    {
        txt_Score.text = "Score: " + score.ToString();
    }

    public void UpdateTime(float time)
    {
        txt_Time.text = "Time: " + time.ToString("F2");
    }
}
