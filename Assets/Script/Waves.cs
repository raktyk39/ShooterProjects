 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Waves : MonoBehaviour
{
    public ZombeMove zombieMove; 

     public GameObject [] ZombieCount;

     public int maxZombiesOnWave = 10; 

     public int ZombieKillOnWave;

     public ZombeMove zombmovi ; 

     public int WavesCaunt ;

     public int ZombiHealthAdding;

     public int DamageforPlayerAdding;
     
  
           

    void Start ()
    {
           

       zombmovi = FindObjectOfType<ZombeMove>();


    }
 
    void Update()
    {
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
        WavesCaunt ++ ;
        DamageforPlayerAdding = DamageforPlayerAdding + 50;
        ZombiHealthAdding = ZombiHealthAdding + 50;
        maxZombiesOnWave ++;
        ZombieKillOnWave = 0;
    

    for(int countZombie = 0; countZombie < ZombieCount.Length; countZombie++) {
        
        Destroy(ZombieCount[countZombie].gameObject);
    }

  }





}
