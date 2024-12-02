using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject focusObject;
    public Vector3 _offset;
    public float smoothSpeed = 0.125f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // _offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // LateUpdate runs after all scripts Update() runs, effective for camera controlling
    private void LateUpdate()
    {
        Vector3 desiredPosition = _offset + focusObject.transform.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        
    }
}
