using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiSettings : MonoBehaviour {
    public Button soundFx;
    public Button Music;
    public Button Low;
    public Button Medium;
    public Button High;
    public void FX()
    {
        if (soundFx.gameObject.tag == "but")
        {

            soundFx.gameObject.tag = "notbuy";
            PlayerPrefs.SetString("fx", "off");
            soundFx.GetComponent<Image>().color = Color.red;
        }
        else{

            soundFx.gameObject.tag = "but";
            PlayerPrefs.SetString("fx", "on");
            soundFx.GetComponent<Image>().color = Color.blue;

        }
    }
    public void mMusic()
    {
        if (Music.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("music", "off");
            Music.gameObject.tag = "notbuy";
            Music.GetComponent<Image>().color = Color.red;
        }
        else
        {
            Music.GetComponent<Image>().color = Color.blue;
            PlayerPrefs.SetString("music", "on");
            Music.gameObject.tag = "but";
        }
    }
    public void GLow()
    {
        if (Low.gameObject.tag == "notbuy")
        {
            Medium.gameObject.tag = "notbuy";
            High.gameObject.tag = "notbuy";
            Low.gameObject.tag = "but";
            Low.GetComponent<Image>().color = Color.red;
            Medium.GetComponent<Image>().color = Color.blue;
            High.GetComponent<Image>().color = Color.blue;
            PlayerPrefs.SetString("grahp", "low");

        }
    }
    public void GMedium()
    {
        if (Medium.gameObject.tag == "notbuy")
        {
            Medium.gameObject.tag = "but";
            High.gameObject.tag = "notbuy";
            Low.gameObject.tag = "notbuy";
            Low.GetComponent<Image>().color = Color.blue;
            Medium.GetComponent<Image>().color = Color.red;
            High.GetComponent<Image>().color = Color.blue;
            PlayerPrefs.SetString("grahp", "med");


        }
    }
    public void GHIGH()
    {
        if (High.gameObject.tag == "notbuy")
        {
            Medium.gameObject.tag = "notbuy";
            High.gameObject.tag = "but";
            Low.gameObject.tag = "notbuy";
            Low.GetComponent<Image>().color = Color.blue;
            Medium.GetComponent<Image>().color = Color.blue;
            High.GetComponent<Image>().color = Color.red;
            PlayerPrefs.SetString("grahp", "high");


        }
    }
}
