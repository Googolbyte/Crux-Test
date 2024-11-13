using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject pausedPanel;
    public StateMachineSO playerStateMachine;
    public StateSO pausedState;

    private StateSO _previousState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStateMachine.StateChange += RenderPauseScreen;
        RenderPauseScreen();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (playerStateMachine.currentState != pausedState)
            {
                _previousState = playerStateMachine.currentState;
                playerStateMachine.currentState = pausedState;
            }
            else
            {
                playerStateMachine.currentState = _previousState;
            }
        }
    }

    public void RenderPauseScreen()
    {
        if (playerStateMachine.currentState == pausedState)
        {
            pausedPanel.SetActive(true);
        }
        else
        {
            pausedPanel.SetActive(false);
        }
    }
}
