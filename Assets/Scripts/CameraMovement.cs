using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float smoothSpeed = 2f;
    public Transform vehicle;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - vehicle.position;
    }

    private void LateUpdate()
    {
        MoveCameraWithLerp();
    }
    private void MoveCameraWithoutLerp()
    {
        transform.position = vehicle.position + offset;
    }
    private void MoveCameraWithLerp()
    {
        Vector3 expectedPosition = vehicle.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, expectedPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
