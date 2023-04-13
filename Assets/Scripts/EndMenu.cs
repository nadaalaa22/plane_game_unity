using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    
    public void StartGame()
    {   // to open the next scen
        // 1 in bulid screen 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2 );
    }
    public void ReStartGame()
    {   // to open the next scen
        // 1 in bulid screen 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
