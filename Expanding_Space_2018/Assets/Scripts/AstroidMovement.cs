using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{

    [SerializeField]
    private float RotationSpeed = 50f;
    public int AstroidHP = 3;
    //private StardustSpawner stardustSpawner;
    public GameObject Stardust;
    public int minInt = 1;
    public int maxInt = 10;

    private void Start()
    {
        //stardustSpawner = GameObject.FindObjectOfType<StardustSpawner>();
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, RotationSpeed) * Time.deltaTime);

        // on 0 hp
        if (AstroidHP <= 0)
        {
            Destroy(this.gameObject);
            RandomDustSpawn();
            SdScore.addScore(5);
            AstroidHP = 3;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // on bullet impact
        if (other.gameObject.tag == "Bullet")
        {
            AstroidHP -= 1;
            Destroy(other.gameObject);
        }

    }
    public void RandomDustSpawn()
    {
        if (Random.Range(minInt, maxInt) < 2)
        {
            Instantiate(Stardust, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}


