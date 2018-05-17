using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float speed = 5;
	void Update () {



        //up movement
        if (Input.GetKey("w"))
        {
            transform.Translate((Vector2.up * speed) * Time.deltaTime);
        }
        //down movement
        if (Input.GetKey("s"))
        {
            transform.Translate((Vector2.down * speed) * Time.deltaTime);
        }
        //left movement
        if (Input.GetKey("a"))
        {
            transform.Translate((Vector2.left * (speed / 2)) * Time.deltaTime);
        }
        //right movement
        if (Input.GetKey("d"))
        {
            transform.Translate((Vector2.right * speed) * Time.deltaTime);
        }

    }
}
