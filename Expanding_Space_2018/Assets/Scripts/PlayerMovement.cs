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

        float horizontalMovement = (speed / 35) * Input.GetAxis("Horizontal");
        float verticalMovement = (speed / 35) * Input.GetAxis("Vertical");

        if (PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate(horizontalMovement, 0, 0);
            transform.Translate(0, verticalMovement, 0);
        }
    }
    

}
