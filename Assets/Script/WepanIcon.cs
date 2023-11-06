using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WepanIcon : MonoBehaviour
{
    public Image imageGlock;
    public Image imageP90;
    public Image imageSmg;
    public List<Image> images = new List<Image>();
    private int currentIndex = 0;

    void Start()
    {
        images.Add(imageGlock);
        images.Add(imageP90);
        images.Add(imageSmg);
        
        UpdateIconDisplay();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeWeapon(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeWeapon(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeWeapon(2);
        }
    }

    void UpdateIconDisplay()
    {
        for (int i = 0; i < images.Count; i++)
        {
            images[i].color = (i == currentIndex) ? new Color32(13, 87, 19, 255) : new Color32(31, 180, 44, 255);
        }
    }

    public void ChangeWeapon(int newIndex)
    {
        currentIndex = newIndex;
        UpdateIconDisplay();
    }
}
