using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Tetris");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void GoToRules()
    {
        SceneManager.LoadScene("Rules");
    }
}
