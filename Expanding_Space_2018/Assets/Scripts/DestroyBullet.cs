using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

    private int BulletX;
    [SerializeField]
    private float TimeToDestroy = 5f;

	void Start () {
        DestroyObject(this.gameObject, TimeToDestroy);
	}

   // BulletX = GameObject.FindGameObjectWithTag("Bullet").transform.position;
}
