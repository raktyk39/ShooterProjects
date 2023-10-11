using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveOfGame : MonoBehaviour
{

public GameObject slaiderOfValiune;

public GameObject Player;

 public float valuiu ;  

 public Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       

    }


   
   [ContextMenu("Save")]
   
  public void saveVoluiums (){

 
 valuiu = slaiderOfValiune.GetComponent<Slider>().value;
PlayerPrefs.SetFloat("ValueAudio",valuiu);

playerPosition = Player.GetComponent<Slider>().deltaMove;
PlayerPrefs.SetVector3("PositionPlayer",deltaMove);


  }

[ContextMenu("Get")]

  public void getValuium () {

  slaiderOfValiune.GetComponent<Slider>().value =  PlayerPrefs.GetFloat("ValueAudio") ; 

 Player.GetComponent<Slider>().deltaMove = PlayerPrefs.GetVector3("PositionPlayer");

  }


}
