using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavesUI : MonoBehaviour
{
    public Text textWaves; 
    public Waves waves;

    void Start()
    {
        waves = FindObjectOfType<Waves>();
            
        textWaves = gameObject.GetComponentInChildren<Text>();
    }

    void Update()
    {
        WavesPrintUI();
    }
    
    void WavesPrintUI ()
    {
        textWaves.text = "Waves " + waves.WavesCaunt;
    }
}
