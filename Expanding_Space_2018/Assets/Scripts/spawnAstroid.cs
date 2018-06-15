using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAstroid : MonoBehaviour {

    public GameObject Astroid;
    public GameObject SmallAstroid;
    public float spawnDelay = 1f;
    private float spawntimer = 0;
    private float smallSpawnTimer = 0;
    new GameObject camera;

    private void Start()
    {
        Astroid = GameObject.FindGameObjectWithTag("Astroid");
        SmallAstroid = GameObject.FindGameObjectWithTag("SmallAstroid");
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    void Update()
    {
        spawntimer += Time.deltaTime;
        if (spawntimer >= spawnDelay && PauseMenuScript.GameIsPaused == false)
        {
            SpawnMeteor();
            SpawnSmallMeteor();
        }

    }
    private void SpawnMeteor()
    {

        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 10f, Random.Range(-4.5f, 4.5f), 0);
        Instantiate(Astroid, spawnPosition, Quaternion.identity);

        spawntimer = 0;
    }

    private void SpawnSmallMeteor()
    {
        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 10f, Random.Range(-4.5f, 4.5f), 0);
        Instantiate(SmallAstroid, spawnPosition, Quaternion.identity);

        smallSpawnTimer = 0;
    }
}
