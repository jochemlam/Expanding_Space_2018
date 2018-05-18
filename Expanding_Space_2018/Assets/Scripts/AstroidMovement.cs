using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{

    [SerializeField]
    private float RotationSpeed = 50f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, RotationSpeed) * Time.deltaTime);

       // transform.Translate(Vector2.right * 0.1f);

    }
}


