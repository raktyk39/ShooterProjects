using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmooP90 : MonoBehaviour
{
    public GameObject p90 ;
   
    private void Start()
    {
        p90 = GameObject.FindGameObjectWithTag("GunP90"); // Даный игрово обьект мы находим по тегу
    }

    private void OnTriggerEnter(Collider other) 
    { 
        if (   other.gameObject.tag == "Player" )
        {
           p90.GetComponent<GunP90>().BagAmmo =  p90.GetComponent<GunP90>().BagAmmo + 100;
           Destroy(gameObject);
        }
    }
}
