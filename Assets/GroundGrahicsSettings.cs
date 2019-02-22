using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGrahicsSettings : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if ( PlayerPrefs.GetString("grahp") == "low")
        {
            this.gameObject.SetActive(false);
        }
    }

}
