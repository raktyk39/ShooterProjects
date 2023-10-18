using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPouse : MonoBehaviour
{

     public GameObject intarfacePauce;

    
    // Start is called before the first frame update
    void Start()
    {
        intarfacePauce.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void PousGame () {




if (intarfacePauce.activeSelf == true) {

Time.timeScale = 0;


}

else {

Time.timeScale = 1;

}

}

public void IntarfaceOnClick() {

intarfacePauce.SetActive(!intarfacePauce.activeSelf);

}
    
}
