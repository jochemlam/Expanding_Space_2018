using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdScore : MonoBehaviour {

    [SerializeField]
    private int scoreWorth = 5;

    private Rigidbody2D bullet;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            addScore(scoreWorth);
            Destroy(this.gameObject);
        }
        
    }

    public static void addScore(int Amount)
    {
        ScoreScript.ScoreValue += Amount;
    }
}
