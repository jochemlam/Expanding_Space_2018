using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
    public Rigidbody2D bullet;
    new GameObject camera;

    private StardustSpawner stardustSpawner;
    
    // Find all necessary objects
    void Start () {
        bullet = GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        stardustSpawner = GameObject.FindObjectOfType<StardustSpawner>();
    }

    // delete bullets out of screen
    void Update()
    {
        float maxRange = camera.transform.position.x + 8.5f;
        if (bullet.transform.position.x >= maxRange)
        {
            Destroy(this.gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Astroid")
        {
            
            stardustSpawner.RandomDustSpawn();
            SdScore.addScore(5);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

    }

}
