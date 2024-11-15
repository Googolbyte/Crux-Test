using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 12.0f;
    public float rotateSpeed = 1.0f;
    private CharacterController _controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");
        if (turn != 0)
        {
            transform.Rotate(Vector3.up * turn * rotateSpeed * Time.deltaTime);
        }
        
        if (forward != 0)
        {
            _controller.Move(transform.forward * forward * moveSpeed * Time.deltaTime);
        }
        
    }
}
