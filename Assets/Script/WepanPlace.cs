using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WepanPlace : MonoBehaviour
{

    public MeshRenderer meshRenderer;

    public GameObject[] WeaponBag;

    public GameObject CurrentWeapon;

    public int WeaponBagLength;


      
    
    void Start()
    {
       
     meshRenderer = GetComponent<MeshRenderer>();
     WeaponBagLength = transform.childCount;
     WeaponBag = new GameObject[WeaponBagLength];

      
     for ( int i = 0; i < WeaponBagLength; i++)
     {

      WeaponBag[i] = transform.GetChild(i).gameObject;
       
     }

     CurrentWeapon = WeaponBag[0];
            
        //ChooseWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        

     if ( Input.GetKey(KeyCode.Alpha1))
     {

       CurrentWeapon = WeaponBag[0];
       ChooseWeapon();

     }

     if ( Input.GetKey(KeyCode.Alpha2))
     {

       CurrentWeapon = WeaponBag[1];
       ChooseWeapon();

     }


     if ( Input.GetKey(KeyCode.Alpha3))
     {

         CurrentWeapon = WeaponBag[2];
         ChooseWeapon();

     }

    }




   
   void ChooseWeapon()
   {
      for (int i = 0; i < WeaponBagLength; i++)

      if (WeaponBag[i] != CurrentWeapon)
      {
        WeaponBag[i].GetComponent<MeshRenderer>().enabled = false ;
      }
      
      else {
        WeaponBag[i].GetComponent<MeshRenderer>().enabled = true ;
      }
   }






    
}
