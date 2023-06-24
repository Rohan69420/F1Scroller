using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    //Camera MainCamera;
    public float movementScale=1.0f;
    private Vector3 lastMousePos,registeredPosition;
    private bool held=false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            held = true;
            lastMousePos = Input.mousePosition;
        }

        if (held == true && registeredPosition!=Input.mousePosition)
        {
            RotationUpdater(lastMousePos, Input.mousePosition);
            registeredPosition=Input.mousePosition;
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            held = false;
        }
    }

    void RotationUpdater(Vector3 lastMousePos, Vector3  currentMousePos)
    {
        transform.Rotate(0,-movementScale*(lastMousePos.x-currentMousePos.x), -movementScale * (lastMousePos.y - currentMousePos.y));
    }
}
