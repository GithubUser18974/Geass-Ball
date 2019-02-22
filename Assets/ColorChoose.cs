using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ColorChoose : MonoBehaviour {
    public Color Light;
    public Color Dark;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetString("cam") == "light")
        {
            this.GetComponent<Camera>().backgroundColor = Light;
        }
        else
        {
            this.GetComponent<Camera>().backgroundColor = Dark;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetString("cam") == "light")
        {
            this.GetComponent<Camera>().backgroundColor = Light;
        }
        else
        {
            this.GetComponent<Camera>().backgroundColor = Dark;
        }
    }
}
