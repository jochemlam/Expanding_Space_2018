using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private float ScoreValue = 0f;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreValue += 0.0334f;

        score.text = "Score: " + Mathf.Round(ScoreValue);
    }
}
