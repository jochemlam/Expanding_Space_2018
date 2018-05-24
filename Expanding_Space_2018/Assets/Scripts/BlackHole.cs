using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "bullet(Clone)")
        {
            Destroy(other.gameObject);
        }
    }
}


