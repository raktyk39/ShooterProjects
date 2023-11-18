using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnCollisionEnter ( Collision other )
    {
        if ( other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Win");
        }
    } 
}
