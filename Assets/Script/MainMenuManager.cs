using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
      public GameObject butoncContinue;

      void Start()
      {
         if ( PlayerPrefs.GetInt("beSave") == 1) 
         {
            butoncContinue.SetActive(true);
         }
         else 
         {
                  butoncContinue.SetActive(false);
         }
            print( PlayerPrefs.GetInt("beSave"));
      }
}
