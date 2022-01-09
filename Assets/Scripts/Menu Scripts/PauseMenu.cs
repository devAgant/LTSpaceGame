using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static KeyCode pauseKey = KeyCode.Escape;
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    
    
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.GetComponent<CanvasGroup>().alpha = 0;
        optionsMenuUI.GetComponent<CanvasGroup>().blocksRaycasts = false;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Main Menu1");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    public void LoadOptions()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.GetComponent<CanvasGroup>().alpha = 1;
        optionsMenuUI.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void LoadPause() {
        pauseMenuUI.SetActive(true);
        optionsMenuUI.GetComponent<CanvasGroup>().alpha = 0;
        optionsMenuUI.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
