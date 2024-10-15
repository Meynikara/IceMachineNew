using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ZoomScript : MonoBehaviour
{
    private Vector3 initialScale;
    private Vector3 newScale;
    public float minval;
    public float maxval;
    void Start()
    {
        initialScale= transform.localScale;
    }
    void Update()
    {
        
    }
    public void ZoomIn()
    {
        newScale = transform.localScale * 1.2f;
        Clamp(newScale);
    }

    public void ZoomOut()
    {
        newScale = transform.localScale / 1.2f;
        Clamp(newScale);
    }

    private void Clamp(Vector3 newScale)
    {
        newScale.x = Mathf.Clamp(newScale.x, initialScale.x * minval, initialScale.x * maxval);
        newScale.y = Mathf.Clamp(newScale.y, initialScale.y * minval, initialScale.y * maxval);
        newScale.z = Mathf.Clamp(newScale.z, initialScale.z * minval, initialScale.z * maxval);
        transform.localScale = newScale;
        Debug.Log(transform.localScale);
    }
    public void resetScale()
    {
        Debug.Log("DASDASd");
        transform.localScale = new Vector3(1, 1, 1);
        Debug.Log(transform.localScale);
    }
    public void resetScale1()
    {
        transform.localScale = new Vector3(1.492854f, 1.492854f, 1.492854f);
    }

    public void grossreset()
    {
        transform.localScale = new Vector3(0.8726552f, 0.8726552f, 0.8726552f);
    }

    public void reset_Scaling()
    {
        transform.localScale = initialScale;
    }
}
