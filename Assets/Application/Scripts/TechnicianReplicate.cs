using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnicianReplicate : MonoBehaviour
{
    public GameObject Replicate;
  

 
    void Update()
    {
        Vector3 secondCubePosition = Replicate.transform.position;
        secondCubePosition.y = transform.position.y;
        secondCubePosition.x = -transform.position.x;
        secondCubePosition.z = transform.position.z +1.3f;
      



        Replicate.transform.position = secondCubePosition;

    }
}
