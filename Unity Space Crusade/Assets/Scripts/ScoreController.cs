using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    public TMP_Text scoreUI;
    public TMP_Text bestScoreUI;
    public int score = 0;
    public static int bestScore = 0;
    public void updateScore()
    {
        score++;
        scoreUI.text = score.ToString();
         Debug.Log(score);
         Debug.Log(bestScore);
        if (score > bestScore)
        {
            bestScore = score;
            bestScoreUI.text = bestScore.ToString();
        }

    }

}
