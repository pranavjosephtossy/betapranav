using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
 public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
