using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touchCamera : MonoBehaviour
{
    public float RotX;
    public float RotY;
    public float RotationSensitivity = 8f;
    public float distanceFromCamera = 12f;


    public Transform target;

    private void Update()
    {
        RotX -= Input.GetAxis("Mouse Y") * RotationSensitivity;
        RotY += Input.GetAxis("Mouse X") * RotationSensitivity;


        Vector3 targetRotation = new Vector3(RotX, RotY);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * distanceFromCamera;
    }
}
