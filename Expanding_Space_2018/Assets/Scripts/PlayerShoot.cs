using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    private float bulletSpeed = 10f;
    [SerializeField]
    private Rigidbody2D bullet;

    //fire the bullet
    void Fire()
    {
        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
}
