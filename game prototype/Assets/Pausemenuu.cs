using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
            }

    public void QuitGame()
    {
        Debug.Log("Quittig game...");
    }
}
