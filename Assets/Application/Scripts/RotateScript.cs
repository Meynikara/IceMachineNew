using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] private float speedLeft = 100f;
    [SerializeField] private float speedRight = 30f;

    private Quaternion initialRotation;

    private bool rotatingLeft = false;
    private bool rotatingRight = false;
    private float rotationAmount = 0f;

    ObjectRotate _rot;
    private void Start()
    {
        initialRotation = transform.rotation;
        _rot = GetComponent<ObjectRotate>();
    }

    private void Update()
    {
        if (rotatingLeft)
        {
            RotateAround(Vector3.up, speedLeft);
        }
        else if (rotatingRight)
        {
            RotateAround(Vector3.up, -speedRight);
        }
        else if (rotationAmount != 0)
        {
            RotateAround(Vector3.up, rotationAmount);
            rotationAmount = 0; // Reset rotation after applying
        }
    }

    private void RotateAround(Vector3 axis, float amount)
    {
        float deltaTime = Time.timeScale == 0 ? Time.unscaledDeltaTime : Time.deltaTime;
        transform.Rotate(axis, amount * deltaTime);
    }

    public void HoldLeft()
    {
        rotatingLeft = true;
    }

    public void ReleaseLeft()
    {
        rotatingLeft = false;
    }

    public void HoldRight()
    {
        rotatingRight = true;
    }

    public void ReleaseRight()
    {
        rotatingRight = false;
    }

   

    public void ResetRotation()
    {
        ReleaseLeft();
        ReleaseRight();
        transform.rotation = initialRotation;
    }


}
