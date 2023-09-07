using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmooP90 : MonoBehaviour
{
    public GameObject p90 ;
    // Start is called before the first frame update
    void Start()
    {
      // Даный игрово обьект мы находим по тегу
        p90 = GameObject.FindGameObjectWithTag("GunP90");
    }

    // Update is called once per frame
     void OnTriggerEnter(Collider other) {
          
          if (   other.gameObject.tag == "Player" )
          {

           p90.GetComponent<GunP90>().BagAmmo =  p90.GetComponent<GunP90>().BagAmmo + 100;
           Destroy(gameObject);

          }


    }
}
