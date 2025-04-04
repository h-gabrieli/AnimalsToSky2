using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed;

    public Vector3 offset;

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 newPosition = target.position + offset;

            newPosition.z = transform.position.z;

            newPosition.x = transform.position.x;


            Vector3 smoothPos = Vector3.Lerp(transform.position, newPosition, smoothSpeed);

            transform.position = smoothPos;
        }
    }
}
