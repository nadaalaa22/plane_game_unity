using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void EsayGame()
    {   // to open the next scen
        // 1 in bulid screen 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HardGame()
    {   // to open the next scen
        // 1 in bulid screen 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
