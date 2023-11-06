using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinIntarface : MonoBehaviour
{
    public void MainMenu () 
    {
        SceneManager.LoadScene ("Menu");
    }

    public void ExitGame () 
    {
        Application.Quit();
    }
}
