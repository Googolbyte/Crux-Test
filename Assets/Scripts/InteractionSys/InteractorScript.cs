using UnityEngine;
using UnityEngine.InputSystem;

public class InteractorScript : MonoBehaviour
{
    [Header("Interaction")]
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionRadius = 0.5f;
    [SerializeField] private LayerMask interactableMask;

    private readonly Collider[] colliders = new Collider[3]; //how many colliders in level
    [SerializeField] private int numFound; //number of colliders found in interactable mask

    private InteractInterface interactable;
    [SerializeField] private InteractionPromptUI interactionPromptUI;

    void Update()
    {
        //return number of colliders found in interactable mask at the interaction point
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionRadius, colliders, interactableMask);
        if (numFound >0)
        {
            interactable = colliders[0].GetComponent<InteractInterface>();

            if (interactable != null)
            {
                if (!interactionPromptUI.isDisplayed)
                {
                    interactionPromptUI.SetUp(interactable.InteractionPrompt);
                }
                if (Keyboard.current.eKey.wasPressedThisFrame)
                    {
                        interactable.interact(this);
                    }
            }
        }
        else 
        {
            if (interactable !=null)
            {
                interactable = null;
            }
            if (interactionPromptUI.isDisplayed)
            {
                interactionPromptUI.ClosePanel();
            }
           
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionRadius);
    }
}
