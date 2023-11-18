using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillUI : MonoBehaviour
{
    private Waves _waves;
    public Text [] textOfKills;

    private void Start()
    {
        _waves = FindObjectOfType<Waves>();
        textOfKills = GetComponentsInChildren<Text>();
    }

    private void Update()
    {
        KillsUI();
    }

    public void KillsUI () 
    {
        textOfKills[0].text =  "Kills:" + _waves.ZombieKillOnWave;
    }
}
