using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioForParcing : MonoBehaviour
{

    public Slider valiuForAudio ;

 

    public AudioSource fondsSong;
    // Start is called before the first frame update
    void Start()
    {
      
        valiuForAudio.value = 100;

        fondsSong = GetComponent<AudioSource>();

         

       

    }

    // Update is called once per frame
    void Update()
    {
        fondsSong.volume = valiuForAudio.value ;

    }
}
