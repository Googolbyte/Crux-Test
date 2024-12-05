using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public string sceneName;


  
    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
private void OnTriggerEnter (Collider other)
{
    LoadA(sceneName);
}

}
