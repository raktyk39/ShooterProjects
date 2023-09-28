using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinIntarface : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    

    void OnCollisionEnter ( Collision other )
    {
       
    
      if ( other.gameObject.tag == "Player")
      {

           SceneManager.LoadScene("Win");

      }


    }


     
     
}
