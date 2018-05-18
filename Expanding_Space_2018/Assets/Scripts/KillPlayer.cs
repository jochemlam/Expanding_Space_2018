using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        Destroy(other.gameObject);
        Destroy(this.gameObject);
	}
}
