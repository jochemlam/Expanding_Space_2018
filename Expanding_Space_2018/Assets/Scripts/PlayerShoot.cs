using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    private float bulletSpeed = 10f;
    [SerializeField]
    private Rigidbody2D bullet;
    

        [SerializeField]
    private float Delay;

    //fire the bullet
    void Fire()
    {
        
        Vector3 bulletpos = (transform.position + new Vector3(2f, 0, 0));

        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, bulletpos, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
        Delay = 0.5f;
    }

    // Setup delay between bullets
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Delay == 0f 
            && PauseMenuScript.GameIsPaused == false)
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
