using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    bool isDragging = false;
    bool canMove;

    private void Start()
    {
       
    }

    private void Update()
    {
        if (!canMove)
            return;

        if (Input.GetMouseButtonDown(0) && !isDragging)
        {
            StartDragging();
        }
        else if (Input.GetMouseButtonUp(0) && isDragging)
        {
            StopDragging();
        }

        if (isDragging)
        {
            MoveObject();
        }
    }

    private void StartDragging()
    {
        isDragging = true;
        mZCoord = Camera.main.WorldToScreenPoint(
         gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private void StopDragging()
    {
        isDragging = false;
    }

    private void MoveObject()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

  

    private Vector3 mOffset;
    private float mZCoord;


    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen

        mousePoint.z = mZCoord;

        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    public void CanMove(bool move)
    {
        canMove = move;
    }



}
