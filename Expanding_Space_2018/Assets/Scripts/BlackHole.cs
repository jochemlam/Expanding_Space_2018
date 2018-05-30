using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

    new GameObject camera;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        // move the bullets
        if (other.gameObject.name == "bullet(Clone)")
        {
            Destroy(other.gameObject);
        }
    }

    private void Update()

        // delete blackholes
    {
        float minRangexBlackHole = camera.transform.position.x - 10f;

        if (this.gameObject.transform.position.x <= minRangexBlackHole)
        {
            Destroy(this.gameObject);
        }
    }
}


