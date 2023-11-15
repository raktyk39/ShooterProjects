using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void ReloadGame ()
    {
        SceneManager.LoadScene("Parking");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
