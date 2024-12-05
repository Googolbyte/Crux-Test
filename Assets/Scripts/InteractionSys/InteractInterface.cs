using UnityEngine;

public interface InteractInterface
{
    public string InteractionPrompt {get;}

    public bool interact(InteractorScript interactor);
    
    
}
