using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "Scriptable Objects/State")]
public class StateSO : ScriptableObject
{
    public string stateName;

    public bool Is(string stateName)
    {
        return stateName == this.stateName;
    }
}
