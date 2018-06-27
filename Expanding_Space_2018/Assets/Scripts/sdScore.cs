using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SdScore : MonoBehaviour {

    [SerializeField]
    private int scoreWorth = 5;
    public float duration = 1f;
    private Rigidbody2D bullet;
    [SerializeField]
    private AudioClip AudioFile;
    [SerializeField]
    private AudioSource SoundSource;

    private void Start()
    {
        SoundSource.clip = AudioFile;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(HandleCollision(other));
        }
    }


    public IEnumerator HandleCollision(Collider2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            SoundSource.Play();
            addScore(scoreWorth);

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            yield return new WaitForSeconds(duration);

            Destroy(this.gameObject, 1.732f);
        }
        
    }

    public static void addScore(int Amount)
    {
        ScoreScript.ScoreValue += Amount;
    }
}
