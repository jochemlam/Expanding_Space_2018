using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdScore : MonoBehaviour {

    [SerializeField]
    private int scoreWorth = 5;

    private Rigidbody2D bullet;
    [SerializeField]
    private AudioClip AudioFile;
    [SerializeField]
    private AudioSource SoundSource;

    private void Start()
    {
        SoundSource.clip = AudioFile;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SoundSource.Play();
            addScore(scoreWorth);
            Destroy(this.gameObject);
        }
        
    }

    public static void addScore(int Amount)
    {
        ScoreScript.ScoreValue += Amount;
    }
}
