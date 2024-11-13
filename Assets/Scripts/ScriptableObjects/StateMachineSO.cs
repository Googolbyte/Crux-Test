using System.Data;
using UnityEngine;

[CreateAssetMenu(fileName = "New StateMachine", menuName = "Scriptable Objects/State Machine")]
public class StateMachineSO : ScriptableObject
{
    public delegate void StateChangeEventHandler();
    public StateChangeEventHandler StateChange;

    public bool debugMachine = false;
    public StateSO initialState;
    private StateSO _state;
    public StateSO currentState
    {
        get
        {
            return _state;
        }
        set
        {
            _state = value;
            if (debugMachine)
            {
                Debug.Log($"Updated state to: {currentState.name}", this);
            }
            StateChange?.Invoke();
        }
    }
}
