using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {

    public float multiplier = 1.4f;
    public float duration = 3f;

    public float modifier = 1.5f;

    public GameObject pickupEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider2D Player)
    {
        Debug.Log("Slow Down Enabled");
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;


        //Player.transform.localScale *= multiplier;
        MoveWorld.WorldSpeed = MoveWorld.WorldSpeed / modifier;

        yield return new WaitForSeconds(duration);

        //Player.transform.localScale /= multiplier;
        MoveWorld.WorldSpeed = MoveWorld.WorldSpeed * modifier;
        Debug.Log("Slow Down Disabled");

    Destroy(gameObject);


    }
}
