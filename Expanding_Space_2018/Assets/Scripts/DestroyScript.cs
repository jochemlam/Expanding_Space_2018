using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
    public Transform bullet;
    new GameObject camera;

   void Start () {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // delete bullets out of screen
    void Update()
    {
        float maxRangex = camera.transform.position.x + 8.5f;
        float minRangex = camera.transform.position.x - 8.5f;
        float maxRangey = camera.transform.position.y + 6.5f;
        float minRangey = camera.transform.position.y - 6.5f;


        if (bullet.transform.position.x >= maxRangex || bullet.transform.position.x <= minRangex 
            || bullet.transform.position.y >= maxRangey || bullet.transform.position.y <= minRangey)
        {
            Destroy(this.gameObject);
        }
    }
}
