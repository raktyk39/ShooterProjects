using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WepanIcon : MonoBehaviour

{

public Image [] images;

public int WepanIconLenth ; 
    
    // Start is called before the first frame update
    void Start()
    {
        images = gameObject.GetComponentsInChildren<Image>();

        WepanIconLenth = transform.childCount;

      //  transform.GetChild(0).GetComponent<Image>().color = new Color32(13,87,19,255);
    }

    // Update is called once per frame
    void Update()
    {
        
      if ( Input.GetKey(KeyCode.Alpha1)) {

           transform.GetChild(0).GetComponent<Image>().color = new Color32(13,87,19,255);
             
           

      }
      

      if ( Input.GetKey(KeyCode.Alpha2)) {

           transform.GetChild(1).GetComponent<Image>().color = new Color32(13,87,19,255);

      }


      if ( Input.GetKey(KeyCode.Alpha3)) {

           transform.GetChild(2).GetComponent<Image>().color = new Color32(13,87,19,255);

      }


    }


    void ChoseWeponIcon () {


for (int i = 0; i < WepanIconLenth;i++)

  


    }
}
