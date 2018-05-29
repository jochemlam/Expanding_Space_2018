using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorld : MonoBehaviour {

    public float WorldSpeed = 0.03f;

    void Update () {

        // move the damn world
        if (PauseMenuScript.GameIsPaused == false)
        {
            transform.Translate(WorldSpeed, 0, 0 * Time.deltaTime);
        }
    }
}
