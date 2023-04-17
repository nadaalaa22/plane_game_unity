using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerMenu : MonoBehaviour
{
    public void StartGame()
    {   // to open the next scen
        // 1 in bulid screen 


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);



    }
}
