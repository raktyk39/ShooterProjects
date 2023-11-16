using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillUI : MonoBehaviour
{
    Waves _waves;
    public Text [] textOfKills;

    void Start()
    {
        _waves = FindObjectOfType<Waves>();
        textOfKills = GetComponentsInChildren<Text>();
    }

    void Update()
    {
        KillsUI();
    }

    public void KillsUI () 
    {
        textOfKills[0].text =  "Kills:" + _waves.ZombieKillOnWave;
    }
}
