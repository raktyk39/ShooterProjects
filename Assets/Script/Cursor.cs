using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invert : MonoBehaviour
{
    private bool curcorLocked = false;

    private void Update()
    {
        CursorController();
    }

    public void CursorController()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            curcorLocked = !curcorLocked;
        }
        
        print(curcorLocked);

        if(curcorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
