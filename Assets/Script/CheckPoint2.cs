using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

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
            EditorSceneManager.LoadScene("Terain"); // 1
        }


   }
    
    
}
