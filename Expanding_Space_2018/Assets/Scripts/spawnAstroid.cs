using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAstroid : MonoBehaviour {

    List<GameObject> Astroids = new List<GameObject>();
    public GameObject Astroid;
    public GameObject SmallAstroid;
    public GameObject BigAstroid;
    public float spawnDelay;
    private float spawntimer = 0;
    new GameObject camera;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        Astroids.Add(Astroid);
        Astroids.Add(SmallAstroid);
        Astroids.Add(BigAstroid);
    }


    void Update()
    {
        spawntimer += Time.deltaTime;
        if (spawnDelay > 0.5f && PauseMenuScript.GameIsPaused == false)
        {
            spawnDelay -= 0.0002f;
        }
        else
        {
            spawnDelay = 0.5f;
        }

        if (spawntimer >= spawnDelay && PauseMenuScript.GameIsPaused == false)
        {
            SpawnMeteor();
        }

    }
    private void SpawnMeteor()
    {

        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 10f, Random.Range(-4.5f, 4.5f), 0);
        Instantiate(Astroids[Random.Range(0, Astroids.Count)], spawnPosition, Quaternion.identity);

        spawntimer = 0;
    }
}
