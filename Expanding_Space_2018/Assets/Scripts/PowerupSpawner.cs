using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour {

    List<GameObject> Powerups = new List<GameObject>();
    public float spawnDelay;
    private float spawntimer = 0;
    new GameObject camera;
    public GameObject ShieldPowerup;
    public GameObject SpeedUp;
    public GameObject SpeedDown;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void Awake()
    {
        Powerups.Add(ShieldPowerup);
        Powerups.Add(SpeedUp);
        Powerups.Add(SpeedDown);
    }


    void Update()
    {
        spawntimer += Time.deltaTime;

        if (spawnDelay < 5 && PauseMenuScript.GameIsPaused == false)
        {
            spawnDelay += 0.0002f;
        }
        else
        {
            spawnDelay = 5;
        }

        if (spawntimer >= spawnDelay && PauseMenuScript.GameIsPaused == false)
        {
            SpawnPowerup();
        }

    }
    private void SpawnPowerup()
    {
        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 10f, Random.Range(5f, -5f), 0);
        Instantiate(Powerups[Random.Range(0, Powerups.Count)], spawnPosition, Quaternion.identity);

        spawntimer = 0;
    }
}
