using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    public static bool pause;
    private void Awake()
    {
        pause = false;
    }
    private void Update()
    {        
        CheckPause();
        LeftbuttonPhone();
    }

    private void CheckPause()
    {
        if (pause)
        {
            pausePanel.SetActive(true);
        }
        else
        {
            pausePanel.SetActive(false);
        }
    }

    private void LeftbuttonPhone()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = true;
            Time.timeScale = 0;
        }
    }

    public void BtnPause()
    {
        pause = !pause;
        if (pause == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void BtnQuit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }

    public void BtnHome(string mainMenu)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainMenu);
    }

}