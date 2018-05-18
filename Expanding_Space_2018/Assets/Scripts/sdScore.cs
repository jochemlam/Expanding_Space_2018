using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdScore : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            addScore();
        }
        
    }

    void addScore()
    {
        ScoreScript.ScoreValue += 5;
    }
}
