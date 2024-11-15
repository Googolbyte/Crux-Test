using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject focusObject;

    private Vector3 _offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // LateUpdate runs after all scripts Update() runs, effective for camera controlling
    private void LateUpdate()
    {
        transform.position = _offset + focusObject.transform.position;
    }
}
