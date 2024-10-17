using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnicianReplicate : MonoBehaviour
{
    public GameObject Replicate;

    public Vector3 startingVal;
    public float Xval;
    public float Zval;
    public float XMVal;
    public float ZMVal; 

    private void Start()
    {
        startingVal = transform.position;
        Xval = startingVal.x;
        Zval = startingVal.z;
    }

    void Update()
    {
        Vector3 secondCubePosition = Replicate.transform.position;
        secondCubePosition.y = transform.position.y;

       /* XMVal = Xval - transform.position.x;    
        ZMVal = Zval - transform.position.z;
        secondCubePosition.x = -XMVal;
        secondCubePosition.z = -ZMVal+1.2f;*/
      
        Replicate.transform.position = secondCubePosition;

    }
}
