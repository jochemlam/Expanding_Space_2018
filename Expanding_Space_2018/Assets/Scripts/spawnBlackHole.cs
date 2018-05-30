using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBlackHole : MonoBehaviour {

    public GameObject BlackHole;
    public float spawnDelay = 1f;
    private float spawntimer = 0;
    new GameObject camera;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    
    void Update()
    {
        spawntimer += Time.deltaTime;
        if (spawntimer >= spawnDelay && PauseMenuScript.GameIsPaused == false)
        {
            SpawnBlackHole();
        }

    }
    private void SpawnBlackHole()
    {
        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 10f, Random.Range(5f,-5f), 0);
        Instantiate(BlackHole, spawnPosition, Quaternion.identity);

        spawntimer = 0;
    }
}
