using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float rotateSpeed = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

   private void OnTriggerEnter (Collider other)
   {
        speed = speed * -1;
   }
}
