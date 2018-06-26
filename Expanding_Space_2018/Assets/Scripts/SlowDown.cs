using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {

    public float multiplier = 1.4f;
    public float duration = 3f;
    public float modifier = 1.5f;
    public GameObject pickupEffect;

    // destroy object out of screen
    new GameObject camera;
    public Transform thisObject;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void Update()
    {
        float minRangex = camera.transform.position.x - 10.5f;

        if (thisObject.transform.position.x <= minRangex)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider2D Player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;


        //Player.transform.localScale *= multiplier;
        MoveWorld.WorldSpeed = MoveWorld.WorldSpeed / modifier;

        yield return new WaitForSeconds(duration);

        //Player.transform.localScale /= multiplier;
        MoveWorld.WorldSpeed = MoveWorld.WorldSpeed * modifier;

    Destroy(gameObject);


    }
}
