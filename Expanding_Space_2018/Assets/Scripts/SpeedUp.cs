using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour {

    public float decrease = 2.0f;
    public float duration = 3f;
    public float modifier = 1.5f;

    public MoveWorld _MoveWorld;

    public GameObject pickupEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider2D Player)
    {

        Debug.Log("Speed Up Enabled");
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;


        //Player.transform.localScale /= decrease;
        MoveWorld.WorldSpeed = MoveWorld.WorldSpeed * modifier;

        yield return new WaitForSeconds(duration);

        //Player.transform.localScale *= decrease;
        MoveWorld.WorldSpeed = MoveWorld.WorldSpeed / modifier;
        Debug.Log("Speed Up Disabled");

        Destroy(gameObject);


    }
}
