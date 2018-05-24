using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorld : MonoBehaviour {

    public float WorldSpeed = 3.5f;
	
	
	void Update () {
        transform.Translate(WorldSpeed, 0, 0 * Time.deltaTime);
    }
}
