using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

public GameObject butoncContinue;

    // Start is called before the first frame update
    void Start()
    {
        
     if ( PlayerPrefs.GetInt("beSave") == 1) {
        

        butoncContinue.SetActive(true);
     }

     else {

             butoncContinue.SetActive(false);


     }
    
       print( PlayerPrefs.GetInt("beSave"));

     



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
