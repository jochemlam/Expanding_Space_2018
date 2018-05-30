using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdScore : MonoBehaviour {

    public AudioClip ShootSoundClip;

    public AudioSource SoundManager;

    [SerializeField]
    private int scoreWorth = 5;

    private Rigidbody2D bullet;

    void Start()
    {
        SoundManager.clip = ShootSoundClip;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SoundManager.Play();
            addScore(scoreWorth);
            Destroy(this.gameObject);
        }
        
    }

    public static void addScore(int Amount)
    {
        ScoreScript.ScoreValue += Amount;
    }
}
