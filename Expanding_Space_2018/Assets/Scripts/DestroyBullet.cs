using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {


    [SerializeField]
    private float TimeToDestroy = 5f;

	void Start () {
        DestroyObject(this.gameObject, TimeToDestroy);
	}
}
