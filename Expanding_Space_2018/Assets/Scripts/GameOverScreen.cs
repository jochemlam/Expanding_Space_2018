using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public static float scoreAmount;
    public static float highScore;
    public static float acquiredScore;
    public Text Score;
    public Text HighScore;
    void Start()
    {
        //acquiredScore = ScoreScript.ScoreValue;

        highScore = PlayerPrefs.GetFloat("highScore", highScore);
    }


    void Update()
    {
        if (KillPlayer.PlayerDead == true)
        {
            Score.text = "Score: " + acquiredScore;
            if (acquiredScore > highScore)
           {
                highScore = acquiredScore;
                HighScore.text = "Highscore: " + acquiredScore;

                PlayerPrefs.SetFloat("highScore", highScore);
            }
        }

       
    }
}

