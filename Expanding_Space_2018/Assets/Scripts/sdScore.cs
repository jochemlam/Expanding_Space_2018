using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdScore : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            addScore(30);
            Destroy(this.gameObject);
        }
        
    }

    public static void addScore(int Amount)
    {
        ScoreScript.ScoreValue += Amount;
    }
}
