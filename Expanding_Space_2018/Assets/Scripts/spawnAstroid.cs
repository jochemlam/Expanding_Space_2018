﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAstroid : MonoBehaviour {

    public GameObject Astroid;
    public float spawnTreshold = 1f;
    private float spawntimer = 0;
    new GameObject camera;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    void Update()
    {
        spawntimer += Time.deltaTime;
        if (spawntimer >= spawnTreshold)
        {
            SpawnMeteor();
        }

    }
    private void SpawnMeteor()
    {

        Vector3 spawnPosition = new Vector3(camera.transform.position.x + 5f, Random.Range(-4.5f, 4.5f), 1);
        Instantiate(Astroid, spawnPosition, Quaternion.identity);

        spawntimer = 0;
    }
}
