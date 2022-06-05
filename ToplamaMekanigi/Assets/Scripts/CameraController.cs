using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ballTransform;
    private Vector3 offset;
    public float lerpTime;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

   
    void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpTime * Time.deltaTime);
        transform.position = newPos;
    }
}
