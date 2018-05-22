using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdScore : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            addScore();
            Destroy(this.gameObject);
        }
        
    }

    public static void addScore()
    {
        ScoreScript.ScoreValue += 5;
    }
}
