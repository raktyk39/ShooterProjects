using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPouse : MonoBehaviour
{
    public GameObject intarfacePauce;

    private void Start()
    {
        intarfacePauce.SetActive(false);
    }

    public void PousGame () 
    {
        if (intarfacePauce.activeSelf == true) 
        {
            Time.timeScale = 0;
        }
        else 
        {
            Time.timeScale = 1;
        }

    }

    public void IntarfaceOnClick() 
    {
        intarfacePauce.SetActive(!intarfacePauce.activeSelf);
    }
}
