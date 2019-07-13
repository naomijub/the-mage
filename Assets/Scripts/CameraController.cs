using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothing = 30f;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position + new Vector3(0f, 0f, -100f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetCam = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCam, smoothing * Time.deltaTime);

    }
}
