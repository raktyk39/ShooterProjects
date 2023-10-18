using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint2 : MonoBehaviour
{
    // Список наших чекпоинтов

   public GameObject LVL2;
 

   void Start() {
      
     LVL2 = Resources.Load("Prefabs/SpawnZombe") as GameObject;
    
   }

    void OnTriggerEnter(Collider other) {
    
        if ( other.gameObject == LVL2)
         {
           SceneManager.LoadScene("Terain"); // 1
        }


   }
    
    
}
