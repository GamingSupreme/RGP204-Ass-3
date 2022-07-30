using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        // Sound
        FindObjectOfType<AudioManager>().Play("MenuMusic");
        //Sound
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Sound
        FindObjectOfType<AudioManager>().Play("MenuButton");
        //Sound
    }
    public void QuitGame()
    {
        Debug.Log("The app has been terminated. Next!");
        // Sound
        FindObjectOfType<AudioManager>().Play("MenuButton");
        //Sound
        Application.Quit();
    }
}
