using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float rotateSpeed = 2f;
    [SerializeField] private float rotationProgress = 0f;
    [SerializeField] private bool isRotating;
   

    // Update is called once per frame
    void Update()
    {
        //Rotate robot 180 degrees when it hits a wall
        if (isRotating)
        {
            float rotationStep = rotateSpeed * Time.deltaTime * 180f;
            if (rotationProgress >=180)
            {
                 rotationStep -= rotationProgress - 180f; // Adjust for overshooting
                rotationProgress = 180f;
                isRotating = false;
            }
            transform.Rotate(0f, rotationStep, 0f);
        }
        //Move robot forward
        else
         {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
         }
         AudioManager.Instance.PlaySoundFXClip(AudioManager.Instance.robot_SFX, transform, 1f);
        
    }

   private void OnTriggerEnter (Collider other)
   {
        if (other.CompareTag("Environment"))
        {
            if (!isRotating)
            {
                isRotating = true;
                rotationProgress = 0f;
            }
        
        }
   }

}
