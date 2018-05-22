using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
    public Rigidbody2D bullet;
    public GameObject camera;

    
    

    void Start () {
        bullet = GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");

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
        if (collision.gameObject.tag == "Bullet")
        {
            //spawnStardust.RandomDustSpawn();
            SdScore.addScore(5);
            Destroy(collision.gameObject);
        }

    }

}
