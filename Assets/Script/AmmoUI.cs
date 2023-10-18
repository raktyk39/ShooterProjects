using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class AmmoUI : MonoBehaviour
{

    private Gun gun;
    
    GunP90 gunP90;

    GunVectore gunVectore;


    private Waves waves_;

    


    public Text [] textAmmo;

 

   



    void Start()
    {
        gunP90 = FindObjectOfType<GunP90>();

        gunVectore = FindObjectOfType<GunVectore>();

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
         
            textAmmo[0].text = "CurentAmmo" + gun.currentAmmo;

            textAmmo[1].text = "BagAmmo" + gun.BagAmmo;

            textAmmo[2].text = "CurentAmmo" + gunP90.currentAmmo;

            textAmmo[3].text = "BagAmmo" + gunP90.BagAmmo;

            textAmmo[4].text = "CurentAmmo" + gunVectore.currentAmmo;

            textAmmo[5].text = "BagAmmo" + gunVectore.BagAmmo;
           /*textAmmo[1].text = "BagAmmo; " + gun.BagAmmo;
           textAmmo[2].text = "MaxAmmo " + gun.maxAmmo;
           textAmmo[3].text = "Kill:" + waves_.ZombieKillOnWave;
          */

          

          }
         
     
           
          


    
}
