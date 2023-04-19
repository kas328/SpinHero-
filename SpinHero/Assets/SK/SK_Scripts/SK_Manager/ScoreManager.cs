using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int currentScore;
    public int score;
    [SerializeField] Text scoreText;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            currentScore += score;
        }
    }
    void Update()
    {
        scoreText.text = currentScore.ToString();
    }
}
