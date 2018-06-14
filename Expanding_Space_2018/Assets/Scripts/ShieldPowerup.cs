using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerup : MonoBehaviour
{

    public float duration = 5f;
    public GameObject pickupEffect;
    public GameObject shield;
    public GameObject player;
    public static bool isinvulnerable;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        shield = GameObject.FindGameObjectWithTag("Shield");
        shield.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(Pickup(other));
        }
    }

    void Update()
    {
       shield.transform.position = player.transform.position;
    }

    IEnumerator Pickup(Collider2D Player)
    {

        Debug.Log("Shield picked up");
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //remove pickup
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        //activate shield
        shield.SetActive(true);

        // activate shield here
        ShieldPowerup.isinvulnerable = true;

        yield return new WaitForSeconds(duration);

        // deactivate shield here
        shield.SetActive(false);

        ShieldPowerup.isinvulnerable = false;

        Debug.Log("Shield removed");

        Destroy(gameObject);
    }
}
