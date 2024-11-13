using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12f;
    public StateMachineSO playerStateMachine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStateMachine.currentState.Is("Player Roaming"))
        {
            Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            transform.Translate(new Vector3(input.x, 0, input.y) * speed * Time.deltaTime);
        }        
    }
}
