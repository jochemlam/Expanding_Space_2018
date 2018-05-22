using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStardust : MonoBehaviour {

    public GameObject Stardust;
    private int minInt = 1;
    private int maxInt = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            SdScore.addScore();
            Destroy(this.gameObject);
        }

    }

    void RandomDustSpawn()
    {
        if (Random.Range(minInt, maxInt) < 2)
        {
            Instantiate(Stardust, transform.parent.position, Quaternion.identity);
        }
    }
}
