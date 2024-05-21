using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public string nameScene;
    public Animator transition;
    
    public void SceneGameplay()
    {
        StartCoroutine(LoadLevel(nameScene));        
    }

    public void ExitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    IEnumerator LoadLevel(string sceneName) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
