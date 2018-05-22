using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
    public Rigidbody2D bullet;
    public GameObject camera;

    private StardustSpawner stardustSpawner;
    

    void Start () {
        bullet = GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        stardustSpawner = GameObject.FindObjectOfType<StardustSpawner>();
    }

    void Update()
    {
        float maxRange = camera.transform.position.x + 8.5f;
        if (bullet.transform.position.x >= maxRange)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Astroid")
        {
            
            stardustSpawner.RandomDustSpawn();
            SdScore.addScore(5);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }

}
