using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public AudioClip ShootSoundClip;

    public AudioSource SoundManager;
    

    // Use this for initialization
    void Start () {
        SoundManager.clip = ShootSoundClip;

    }

    // Update is called once per frame
    void Update () {

        SoundManager.Play();

    }
}
