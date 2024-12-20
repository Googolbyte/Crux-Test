using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
   
   public GameObject cutScene;
   
   public void StartButtonClicked()
    {
        AudioManager.Instance.PlaySoundFXClip(AudioManager.Instance.UIButton_SFX, transform, 1f);
        StartCoroutine(LoadCutScene());

    }

    IEnumerator LoadCutScene()
    {
        yield return new WaitForSeconds(2f);
        cutScene.SetActive(true);
        yield return new WaitForSeconds(6f);
        StartGame();
    }

    void StartGame()
    {
        SceneManager.LoadScene(0);
    }
}
