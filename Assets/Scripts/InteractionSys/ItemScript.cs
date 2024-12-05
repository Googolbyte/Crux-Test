using UnityEngine;

public class ItemScript : MonoBehaviour, InteractInterface
{
    
    [SerializeField] private string prompt;
    public string InteractionPrompt => prompt;

    public bool interact(InteractorScript interactor)
    {
        
        Debug.Log("Got an item!");
        return true;
    }

}

