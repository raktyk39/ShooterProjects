using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioForParcing : MonoBehaviour
{
    public Slider valiuForAudio ;
    public AudioSource fondsSong;
 
    void Start()
    {
        valiuForAudio.value = 100;
        fondsSong = GetComponent<AudioSource>();
    }

    void Update()
    {
        fondsSong.volume = valiuForAudio.value ;
    }
}
