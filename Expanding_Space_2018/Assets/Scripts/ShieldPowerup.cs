using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerup : MonoBehaviour
{

    public float duration = 5f;
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

        Debug.Log("Shield picked up");
        Instantiate(pickupEffect, transform.position, transform.rotation);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        // activate shield here
        AstroidMovement.isinvulnerable = true;

        yield return new WaitForSeconds(duration);

        // deactivate shield here
        AstroidMovement.isinvulnerable = false;

        Debug.Log("Shield removed");

        Destroy(gameObject);
    }
}
