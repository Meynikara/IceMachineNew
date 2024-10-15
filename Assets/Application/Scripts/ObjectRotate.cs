using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectRotate : MonoBehaviour
{

    float angleX = 0.0f;
    float angleY = 0.0f;
   public float rotSpeed = 200;
    float rotX;
    float rotY;

   bool canRotate;
    // Use this for initialization
    void Start()
    {

    }
    private bool isDragging = false;
    private Vector3 previousMousePosition;
    private Quaternion initialRotation;


    // Update is called once per frame
    private void Update()
    {
        if (!canRotate)
            return;

        if (Input.GetMouseButtonDown(0) && !isDragging &&  !EventSystem.current.IsPointerOverGameObject() )
        {
            StartDragging();
        }
        else if (Input.GetMouseButtonUp(0) && isDragging )
        {
            StopDragging();
        }

        if (isDragging )
        {
            RotateObject();
        }
    }

    private void StartDragging()
    {
        isDragging = true;
        previousMousePosition = Input.mousePosition;
        initialRotation = transform.rotation;
    }

    private void StopDragging()
    {
        isDragging = false;
    }

    void RotateObject()
    {
         
        rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
       //rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.forward, -rotX);
        transform.Rotate(Vector3.right, rotY);
        

  
        angleX += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
       // angleY += Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
       // angleY = Mathf.Clamp(angleY, -20.0f, 20.0f);
        transform.rotation = Quaternion.Euler(angleY, -angleX, 0);
        
    }

    public void CanRotate(bool rotate)
    {
        canRotate = rotate; 
    }

}