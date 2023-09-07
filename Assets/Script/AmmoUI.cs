using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class AmmoUI : MonoBehaviour
{

    private Gun gun;

    private Waves waves_;

    


    public Text [] textAmmo;

 

   



    void Start()
    {
        gun = FindObjectOfType<Gun>();
          
       waves_ = FindObjectOfType<Waves>();
        

        textAmmo = gameObject.GetComponentsInChildren<Text>();
        
    }

     void Update()
        {
             GunUI();
        }
 
     void GunUI ()
        {
         

           textAmmo[0].text = "BagAmmo; " + gun.BagAmmo;
           textAmmo[1].text = "CurentAmmo " + gun.currentAmmo;
           textAmmo[2].text = "MaxAmmo " + gun.maxAmmo;
           textAmmo[3].text = "Kill:" + waves_.ZombieKillOnWave;
          

          

          }
         
     
           
          


    
}
