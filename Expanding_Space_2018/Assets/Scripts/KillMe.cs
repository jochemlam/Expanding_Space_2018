using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMe : MonoBehaviour {

    [SerializeField]
    private float Timer;
    private void Awake()
    {
        Destroy(this.gameObject, Timer);
    }
}
