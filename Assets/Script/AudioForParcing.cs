using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioForParcing : MonoBehaviour
{
    public Slider valiuForAudio ;
    public AudioSource fondsSong;
 
    private void Start()
    {
        valiuForAudio.value = 100;
        fondsSong = GetComponent<AudioSource>();
    }

    private void Update()
    {
        fondsSong.volume = valiuForAudio.value ;
    }
}
