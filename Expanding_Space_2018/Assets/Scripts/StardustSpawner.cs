using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StardustSpawner : MonoBehaviour {

    public GameObject Stardust;
    public int minInt = 1;
    public int maxInt = 10;


    // spawn dust function
    public void RandomDustSpawn()
    {
        if (Random.Range(minInt, maxInt) < 2)
        {
            Instantiate(Stardust, transform.parent.position, Quaternion.identity);
        }
    }
}
