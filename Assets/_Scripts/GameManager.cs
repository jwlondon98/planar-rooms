using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool inMainMenu = false;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
