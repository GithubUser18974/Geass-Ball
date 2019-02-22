using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour {
    [SerializeField]
    private GameObject Main;
    [SerializeField]
    private GameObject Settings;
    [SerializeField]
    private GameObject Shopping;
    [SerializeField]
    private GameObject Gifts;
    [SerializeField]
    private GameObject LoopingBG;
    private void Start()
    {
        PlayerPrefs.SetInt("vads", 0);

    }
    public void LoadHomeCanvas()
    {
        Main.SetActive(true);
        Settings.SetActive(false);
        Shopping.SetActive(false);
        Gifts.SetActive(false);
        LoopingBG.SetActive(true);
    }
    public void LoadSettingsCanvas()
    {
        Main.SetActive(false);
        Settings.SetActive(true);
        Shopping.SetActive(false);
        Gifts.SetActive(false);
        LoopingBG.SetActive(true);
    }
    public void LoadShoppingCanvas()
    {
        Main.SetActive(false);
        Settings.SetActive(false);
        Shopping.SetActive(true);
        Gifts.SetActive(false);
        LoopingBG.SetActive(true);
    }
    public void LoadGiftsCanvas()
    {
        Main.SetActive(false);
        Settings.SetActive(false);
        Shopping.SetActive(false);
        Gifts.SetActive(true);
        LoopingBG.SetActive(false);
    }
}
