using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{


    [SerializeField]
    private float bulletSpeed;
    [SerializeField]
    private Rigidbody2D bullet;
    [SerializeField]
    private float BulletDelay = 0.5f;
    [SerializeField]
    private AudioClip AudioFile;
    [SerializeField]
    private AudioSource SoundSource;
    private Rigidbody2D bulletClone;




    [SerializeField]
    private float Delay;

    private void Start()
    {
        SoundSource.clip = AudioFile;
    }

    //fire the bullet
    void Fire()
    {
        
        Vector3 bulletpos = (transform.position + new Vector3(2f, 0, 0));

        bulletClone = (Rigidbody2D)Instantiate(bullet, bulletpos, transform.rotation);
        Physics2D.IgnoreCollision(bulletClone.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        
        Delay = BulletDelay;
    }

    // Setup delay between bullets
    void Update()
    {
        bulletSpeed = (PlayerMovement.speed * 4);
        BulletDelay -= 0.00001f;
        if(bulletClone != null)
        {
            bulletClone.velocity = transform.right * bulletSpeed;
        }
        if (Input.GetKey(KeyCode.Space) && Delay == 0f 
            && PauseMenuScript.GameIsPaused == false)
        {

            Fire();
            SoundSource.Play();
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
