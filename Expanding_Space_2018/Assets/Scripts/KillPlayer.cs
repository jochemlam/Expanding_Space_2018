using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

    public AudioClip ShootSoundClip;

    public AudioSource SoundManager;

    public static bool PlayerDead = false;

    void Start()
    {
        SoundManager.clip = ShootSoundClip;

    }

    private void Update()
    {
        
        if (PlayerDead == true)
        {
            SoundManager.Play();
#pragma warning disable CS0618 // Type or member is obsolete
            SceneManager.UnloadScene("Main");
#pragma warning restore CS0618 // Type or member is obsolete

            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
    
 }
