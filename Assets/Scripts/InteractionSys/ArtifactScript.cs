using System.Collections;
using UnityEngine;
using UnityEngine.LowLevelPhysics;


public class ArtifactScript : MonoBehaviour, InteractInterface
{
    
    [SerializeField] private string prompt;
    [SerializeField] public GameObject artifactText;
    public string InteractionPrompt => prompt;

    public bool interact(InteractorScript interactor)
    {
        StartCoroutine(DisplayArtifactText());
        Debug.Log("interact with artifact");
        return true;
    }

    private IEnumerator DisplayArtifactText()
    {
        artifactText.SetActive(true);
       yield return new WaitForSeconds(5);
       artifactText.SetActive(false);
    }
}
