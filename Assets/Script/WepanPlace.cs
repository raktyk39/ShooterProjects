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

        WeaponBagLength = transform.childCount; // считает количество дочерних элементов

        WeaponBag = new GameObject[WeaponBagLength];

      for ( int i = 0; i < WeaponBagLength; i++) // ДАный цикл сделан для того чотбы WeaponBag хранил в себе дочернии обьекты , i это число с помощью которого он указывает сколько обьектов у нас вообще есть и то что сколько у нас есть обьектов то тому и равен WeaponBag
      {
          WeaponBag[i] = transform.GetChild(i).gameObject; // Масив в себе хранит игровые обьекты  
      }

        CurrentWeapon = WeaponBag[0];     
        ChooseWeapon();
    }

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
        {
          if (WeaponBag[i] != CurrentWeapon)
          {
              WeaponBag[i].GetComponent<MeshRenderer>().enabled = false ;
          }
          else 
          {
              WeaponBag[i].GetComponent<MeshRenderer>().enabled = true ;
          }
        }
    }
}
