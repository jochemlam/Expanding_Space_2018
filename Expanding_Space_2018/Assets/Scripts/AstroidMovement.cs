using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{


    public float Speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 0, 5) * Time.deltaTime);// potential rotation

        transform.Translate(Vector2.right * 0.1f);
        if (transform.position.x == 4)
        {
            transform.Translate(Vector2.right * 0.1f);
        }
        if (transform.position.x == -4)

         {
            transform.Translate(Vector2.right * 0.1f);

        }

    }
}


