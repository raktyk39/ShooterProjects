using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;
    
    public int playerHealth = 100;
   
    private void Start()
    {
        slider = FindObjectOfType<Slider>();  // Обращаемся по типу
    }

    private void Update()
    {
        slider.value = playerHealth;  
        Death();
    }

    public void TakePlayerDamage (int playerDamage)
    {
      playerHealth = playerHealth- playerDamage;
    }

    private void Death () 
    {
      if (playerHealth <=0 )
      {
        SceneManager.LoadScene("GameOver");
      }
    }
}
 
