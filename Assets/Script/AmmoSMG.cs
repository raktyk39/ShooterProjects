using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSMG : MonoBehaviour
{
  public GameObject smg;

  private void Start()
  {
    smg = GameObject.FindGameObjectWithTag("GunSmg");
  }

  private void OnTriggerEnter(Collider other) 
  {
      if ( other.gameObject.tag == "Player" )
      {
        smg.GetComponent<GunVectore>().BagAmmo =   smg.GetComponent<GunVectore>().BagAmmo + 10 ;
        Destroy(gameObject);
      }
  } 
}