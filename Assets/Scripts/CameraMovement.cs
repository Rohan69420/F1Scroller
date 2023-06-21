using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    //Camera MainCamera;
    private Vector3 lastMousePos;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = Input.mousePosition;
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            RotationUpdater(lastMousePos, Input.mousePosition);
        }
    }

    void RotationUpdater(Vector3 lastMousePos, Vector3  currentMousePos)
    {
        transform.Rotate(lastMousePos.x-currentMousePos.x,lastMousePos.y-currentMousePos.y,lastMousePos.z-currentMousePos.z);
    }
}
