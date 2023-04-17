using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiddleMenu : MonoBehaviour
{
    public void NextGame()
    {   // to open the next scen
        // 1 in bulid screen 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MainMenu()
    {   // to open the next scen
        // 1 in bulid screen 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
}
