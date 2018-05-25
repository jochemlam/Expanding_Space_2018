using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    //makes the variables and arrays it for multiple object use
    public GameObject[] planet;
    public float gravity = 30f;
    [SerializeField]
    private float range = 9;

    private Rigidbody2D rig2d;

    // Use this for initialization
    void Start()
    {
        //gets the objects
        rig2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        planet = GameObject.FindGameObjectsWithTag("BlackHole");
        //this is used for the planet gravity pull

        for (int i = 0; i < planet.Length; i++)
        {
            Vector2 offset = planet[i].transform.position - transform.position;

            float gravitysqr = offset.sqrMagnitude;

            if (gravitysqr > 0.001f && gravitysqr < range)
            {
                //transform.up = -offset;
                rig2d.AddForce(gravity * offset.normalized / gravitysqr);
            }

        }
    }

}
