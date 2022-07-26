using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("MainScene");
    }  

    public void QuitGame()
    {
        Debug.Log("Game has QUIT");
        Application.Quit();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
