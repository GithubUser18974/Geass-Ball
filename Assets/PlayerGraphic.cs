using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGraphic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if ( PlayerPrefs.GetString("grahp") == "low")
        {
            this.GetComponent<TrailRenderer>().enabled = false;
        }
    }
	
	
}
