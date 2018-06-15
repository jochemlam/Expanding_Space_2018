
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPlayer : MonoBehaviour {

    [SerializeField]
    private AudioClip AudioFile;
    [SerializeField]
    private AudioSource SoundSource;

    public float duration = 3f;
    public float modifier = 0.3f;

    public GameObject speedUpPlayer;

    // Use this for initialization
    void Start()
    {
        SoundSource.clip = AudioFile;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(SpeedUp(other));
        }
    }

    IEnumerator SpeedUp(Collider2D Player)
    {

        Debug.Log("Speed Up Enabled");
        Instantiate(speedUpPlayer, transform.position, transform.rotation);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;


        PlayerMovement.speed = PlayerMovement.speed + modifier;

        yield return new WaitForSeconds(duration);

        PlayerMovement.speed = PlayerMovement.speed - modifier;
        Debug.Log("Speed Up Disabled");

        Destroy(this.gameObject);


    }

    

    
}


