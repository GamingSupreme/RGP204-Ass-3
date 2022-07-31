using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        //Sound
        FindObjectOfType<AudioManager>().Play("MenuMusic");
        //Sound
    }
    public void PlayGame()
    {
        //Sound
        FindObjectOfType<AudioManager>().StopPlaying("MenuMusic");
        FindObjectOfType<AudioManager>().Play("MenuButton");
        FindObjectOfType<AudioManager>().Play("EnvironmentDay");
        //Sound
        SceneManager.LoadScene("MainScene");
    }

    public void MainMenuFunc()
    {
        //Sound
        FindObjectOfType<AudioManager>().Play("MenuMusic");
        //Sound
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Debug.Log("The app has been terminated. Next!");
        Application.Quit();
    }
}
