using TMPro;
using UnityEngine;

public class InteractionPromptUI : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _promptText;
    [SerializeField] private GameObject promptUIPanel;
    public bool isDisplayed = false;
       void Start()
    {
        promptUIPanel.SetActive(false);
    }

    public void SetUp (string promptText)
    {
        _promptText.text = promptText;
        promptUIPanel.SetActive(true);
        isDisplayed = true;

    }
    public void ClosePanel()
    {
        isDisplayed = false;
        promptUIPanel.SetActive(false);
    }
}
