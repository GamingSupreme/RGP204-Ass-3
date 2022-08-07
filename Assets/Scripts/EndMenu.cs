using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    private void Start()
    {
        //Sound
        FindObjectOfType<AudioManager>().Play("EnvironmentNight");
        FindObjectOfType<AudioManager>().Play("WitchCackle");
        FindObjectOfType<AudioManager>().Play("BubblingPot");
        //Sound
    }
    public void ReplayGame()
    {
        //Sound
        FindObjectOfType<AudioManager>().StopPlaying("EnvironmentNight");
        FindObjectOfType<AudioManager>().StopPlaying("BubblingPot");
        FindObjectOfType<AudioManager>().Play("MenuButton");
        //Sound
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Debug.Log("The app has been terminated. Next!");
        Application.Quit();
    }
}
