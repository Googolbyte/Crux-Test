using System.Collections;
using UnityEditor;
using UnityEngine;

public class QuitButton : MonoBehaviour
{

    public void QuitButtonClicked()
    {
        AudioManager.Instance.PlaySoundFXClip(AudioManager.Instance.UIButton_SFX, transform, 1f);
        StartCoroutine(LoadQuit());
    }

    IEnumerator LoadQuit()
    {
        yield return new WaitForSeconds(2f);
        
        if (Application.isEditor)
        {
         EditorApplication.isPlaying = false;  
        }

        else
        {
            Application.Quit();
        }
    }
        
}
