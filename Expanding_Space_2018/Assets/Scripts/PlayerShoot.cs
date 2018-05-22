using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    private float bulletSpeed = 10f;
    [SerializeField]
    private Rigidbody2D bullet;
    //private GameObject Player;

    private float Delay;

    private void Start()
    {
        //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), Player.GetComponent<Collider>());
    }

    //fire the bullet
    void Fire()
    {
        
        Vector3 bulletpos = (transform.position + new Vector3(2f, 0, 0));

        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, bulletpos, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
        Delay = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Delay == 0f)
        {

            Fire();
        }

        if (Delay > 0)
        {
            
            Delay -= 0.83f * Time.deltaTime;
        }
        if (Delay < 0)
        {
            Delay = 0;
        }
    }
}
