using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
    public static float ScoreValue = 0f;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }

  
    void Update()
    {
        ScoreValue += 0.0334f;

        score.text = "Score: " + Mathf.Round(ScoreValue);
    }
}
