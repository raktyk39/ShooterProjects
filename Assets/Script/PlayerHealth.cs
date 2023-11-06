using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;
    
    public int playerHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        slider = FindObjectOfType<Slider>();  // Обращаемся по типу
    }

    void Update()
    {
        slider.value = playerHealth;  
        Death();
    }

    public void TakePlayerDamage (int playerDamage)
    {
      playerHealth = playerHealth- playerDamage;
    }

    void Death () 
    {
      if (playerHealth <=0 )
      {
        SceneManager.LoadScene("GameOver");
      }
    }
}
 
