 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Waves : MonoBehaviour
{

     public GameObject [] ZombieCount;

     public int maxZombiesOnWave = 10; 

     public int ZombieKillOnWave;

     public ZombeMove zombmovi ; 

     public int WavesCaunt ;

     public int ZombiHealthAdding;

     public int DamageforPlayerAdding;


      public int ZombiHealthAddingBig;

     public int DamageforPlayerAddingBig;
     
  
           

    void Start ()
    {
           

       zombmovi = FindObjectOfType<ZombeMove>();


    }
 
    void Update()
    {

         if (ZombieKillOnWave == 13) {
 
           SceneManager.LoadScene("Win");

        }

        
        if ( ZombieKillOnWave >= maxZombiesOnWave)
        {
 
         ChangeWave(); 

        }

        
        CountZombiesOnWave();

    
      

       
    }



    void CountZombiesOnWave(){

       ZombieCount = GameObject.FindGameObjectsWithTag("Zombie");

    }


    void ChangeWave ()
    {   
        maxZombiesOnWave ++;
        ZombieKillOnWave = 0;

        WavesCaunt ++ ;
        
        DamageforPlayerAdding = DamageforPlayerAdding + 10;
        ZombiHealthAdding = ZombiHealthAdding + 30;


       ZombiHealthAddingBig = ZombiHealthAddingBig + 40;
        DamageforPlayerAddingBig =  DamageforPlayerAddingBig + 15;


        
    

    for(int countZombie = 0; countZombie < ZombieCount.Length; countZombie++) {
        
        Destroy(ZombieCount[countZombie].gameObject);
    }

  }





}
