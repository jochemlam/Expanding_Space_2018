﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
    public static float ScoreValue = 0f;
    public static float scoreAmount;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
        scoreAmount = 0.334f;
    }

  
    void Update()
    {
        
        ScoreValue += scoreAmount;

        score.text = "Score: " + Mathf.Round(ScoreValue);
    }
}
