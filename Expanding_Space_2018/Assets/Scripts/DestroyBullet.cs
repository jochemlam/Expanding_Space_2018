using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {
    public Rigidbody2D bullet;
    GameObject camera;

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



}
