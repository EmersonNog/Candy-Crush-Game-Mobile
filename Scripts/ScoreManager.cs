using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text TotalScoreText;
    public int score;
    private int totalScore;

    void Start()
    {
        totalScore = PlayerPrefs.GetInt("Score");
        Debug.Log(PlayerPrefs.GetInt("Score"));
    }

    void Update()
    {
        scoreText.text = "" + score;
        TotalScoreText.text = "" + totalScore;
    }

    public void IncreaseScore(int amountToIncrease)
    {
	    score += amountToIncrease;
        totalScore+=amountToIncrease;
        PlayerPrefs.SetInt("Score", totalScore);
    }
}