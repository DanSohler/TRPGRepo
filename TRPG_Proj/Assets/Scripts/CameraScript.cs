using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Update()
    {
        // gets mouse input
        float mouseX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Vertical") * Time.deltaTime * sensY;


        yRotation -= mouseX;

        xRotation += mouseY;
        xRotation = Mathf.Clamp(xRotation, 0f, 0f);

        // rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
