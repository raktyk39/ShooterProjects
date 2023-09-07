using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuControler : MonoBehaviour
{

    public GameObject panelSettings;

    public Slider vilumeSlider;

    public AudioSource BG_MenuAudio;
    // Start is called before the first frame update
    void Start()
    {
        panelSettings = GameObject.FindGameObjectWithTag("PanelSatings");
        
        vilumeSlider = GetComponentInChildren<Slider>();

        BG_MenuAudio = GetComponent<AudioSource>();

        panelSettings.SetActive(false);
        
    }



    void Update()
    {
        BG_MenuAudio.volume = vilumeSlider.value;
    }
    


  public void StartGame () {

 SceneManager.LoadScene("Parking");

  }





    public void ExitGame () {

    Application.Quit();

    }




    public void Settings () {


        if (panelSettings.activeInHierarchy == false )
        {

           panelSettings.SetActive(true);

        }

        else {

            panelSettings.SetActive(false );
        }
    }
}
