using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithTag : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (this.gameObject.name == "s1"&&PlayerPrefs.GetString("s1")=="yes")
        {
            this.gameObject.SetActive(false);
        }
        else if (this.gameObject.name == "s2" && PlayerPrefs.GetString("s2") == "yes")
        {
            this.gameObject.SetActive(false);
        }
        else if (this.gameObject.name == "s3" && PlayerPrefs.GetString("s3") == "yes")
        {
            this.gameObject.SetActive(false);
        }
        else if (this.gameObject.name == "s4" && PlayerPrefs.GetString("s4") == "yes")
        {
            this.gameObject.SetActive(false);
        }
    }
}
