using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBackground : MonoBehaviour {
    public void SunClick()
    {
        PlayerPrefs.SetString("cam", "light");


    }
    public void MoonClick()
    {
        PlayerPrefs.SetString("cam", "dark");

    }
}
