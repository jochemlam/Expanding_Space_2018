﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroidMovement : MonoBehaviour
{
    [SerializeField]
    private AudioClip AudioFile;
    [SerializeField]
    private AudioSource SoundSource;

    // Destroy astroid vars
    new GameObject camera;
    public Rigidbody2D Astroid;

    // astroid vars
    [SerializeField]
    private float RotationSpeed = 50f;
    public int AstroidHP = 3;
    public static bool isinvulnerable;

    // stardust vars
    public GameObject Stardust;
    public int maxInt = 10;

    void Start()
    {
        isinvulnerable = false;
        SoundSource.clip = AudioFile;
        Astroid = GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        //Stardust = GameObject.FindGameObjectWithTag("StarDust");
    }


    void Update()
    {
        if (PauseMenuScript.GameIsPaused == false) { 
        transform.Rotate(new Vector3(0, 0, RotationSpeed) * Time.deltaTime);
}
        // on 0 hp
        if (AstroidHP <= 0)
        {
            SoundSource.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
                       
            RandomDustSpawn();
            SdScore.addScore(3);
            AstroidHP = 3;

            Invoke("DestroyAstroid", 1);
            
        }

        



        // delete astroids
        float minRangexAstroid = camera.transform.position.x - 10f;

        if (this.gameObject.transform.position.x <= minRangexAstroid)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // on bullet impact
        if (other.gameObject.tag == "Bullet")
        {
            AstroidHP -= 1;
            Destroy(other.gameObject);
        }

        // kill player
        if (other.gameObject.tag == "Player" && isinvulnerable == false)
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            SceneManager.UnloadSceneAsync("Main");
        }

    }
    public void RandomDustSpawn()
        // spawn random dust 1 in 10 chance
    {
        if (Random.Range(1, maxInt) < 2)
        {
            Instantiate(Stardust, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
    void DestroyAstroid()
    {
        Destroy(this.gameObject);
    }
}


