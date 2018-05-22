using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    [SerializeField]
    private float Speed = 5f;
	
	void Update () {

        if (KillPlayer.PlayerDead != true)
        {
            transform.Translate(Speed, 0, 0);
        }
	}
}
