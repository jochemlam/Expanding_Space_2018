﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStardust : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            addScore();
            Destroy(this.gameObject);
        }

    }
}
