using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotator : MonoBehaviour
{
    [SerializeField]    [Tooltip("Speed for the camera rotation")]
    public float speed;

    [SerializeField]
    [Tooltip("Look at which transform")]
    public Transform lookAtTransform;

    [HideInInspector] [Tooltip("Dont fucking bother about this vector")]
    public Vector3 DummyRot;


    // Update is called once per frame
    void Update()
    {


        transform.RotateAround(new Vector3(lookAtTransform.position.x, lookAtTransform.position.y, lookAtTransform.position.z), Vector3.up, speed * Time.deltaTime);
    }
}
