using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public static float speed = 5;

    private void Start()
    {
        ShieldPowerup.isinvulnerable = false;
    }

    void Update () {

        //up movement
        if (Input.GetKey("w") && PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate((Vector2.up * speed) * Time.deltaTime);
        }
        //down movement
        if (Input.GetKey("s") && PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate((Vector2.down * speed) * Time.deltaTime);
        }
        //left movement
        if (Input.GetKey("a") && PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate((Vector2.left * (speed / 1.5f)) * Time.deltaTime);
        }
        //right movement
        if (Input.GetKey("d") && PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate((Vector2.right * speed) * Time.deltaTime);
        }


    }

}
