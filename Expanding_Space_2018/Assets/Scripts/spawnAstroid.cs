using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAstroid : MonoBehaviour {

    public GameObject Astroid;
    public float spawnTreshold = 1f;
    private float spawntimer = 0;

    
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
        Vector3 spawnPosition = new Vector3(0, Random.Range(-4.5f, 4.5f), 10f);
        Instantiate(Astroid, spawnPosition, Quaternion.identity);

        spawntimer = 0;
    }
}
