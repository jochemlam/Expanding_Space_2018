using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Objects : MonoBehaviour {

    private void Awake()
    {
        Invoke("DestroyThisObject", 1);
    }
    public void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }
}
