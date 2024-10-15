using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_position : MonoBehaviour
{
    public Vector3 initialPosition;
    public Quaternion initialRotation;
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }
    public void ResetPositionAndRotation()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}
