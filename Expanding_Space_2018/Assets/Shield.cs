using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private Transform player;
    //private Collider2D playerCollider;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerCollider = player.GetComponent<Collider2D>();
    }

    private void Start()
    {
        SetActive(false);
    }

    public void Activate(float duration)
    {
        StartCoroutine(ShieldTimer(duration));
    }

    private void SetActive(bool active)
    {
        spriteRenderer.enabled = active;
        //playerCollider.enabled = !active;
    }

    IEnumerator ShieldTimer(float duration)
    {
        float timer = 0;
        SetActive(true);
        Physics2D.IgnoreLayerCollision(8, 12, true);


        while (timer < duration)
        {
            timer += Time.deltaTime;
            transform.position = player.transform.position;
            yield return null;
        }

        SetActive(false);
        Physics2D.IgnoreLayerCollision(8, 12, false);
    }
}
