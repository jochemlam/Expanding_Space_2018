using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {

    public float Speed = 2.0f;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * 0.1f);
        if (transform.position.x == 4)
        {
            transform.Translate(-Vector2.right * 0.1f);
        }
        if (transform.position.x == -4)

        {
            transform.Translate(Vector2.right * 0.1f);

        }
        transform.Rotate(new Vector2(0, 0) * Time.deltaTime);
    }
}

