using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
    public static float ScoreValue = 0f;
    public static float scoreAmount;
    public Text score;
    public Text highScore;
    void Start()
    {
        score = GetComponent<Text>();
        highScore = GetComponent<Text>();
        scoreAmount = 0.0334f;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

  
    void Update()
    {
        
        ScoreValue += scoreAmount;
        int number = Mathf.RoundToInt(ScoreValue);
        score.text = number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();

        }
        score.text = "Score: " + Mathf.Round(ScoreValue);
    }
}
