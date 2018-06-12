using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorld : MonoBehaviour {
    
    public static float WorldSpeed = 0.013f;
    private float WorldSpeedIncrease = 0.00003f;

    private void Start()
    {
        WorldSpeed = 0.013f;
    }
    void Update () {

        WorldSpeed += WorldSpeedIncrease;

        // move the damn world
        if (PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate(WorldSpeed, 0, 0 * Time.deltaTime);
        }

        
        if (WorldSpeed >= 0.25f)
        {
            WorldSpeedIncrease = 0;
            WorldSpeed = 0.25f;
        }
    }
}
