using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithName : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        if (this.gameObject.name == "p1" && PlayerPrefs.GetString("p1") == "y")
        {
            this.gameObject.SetActive(false);
        }
        else if (this.gameObject.name == "p2" && PlayerPrefs.GetString("p2") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p3" && PlayerPrefs.GetString("p3") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p4" && PlayerPrefs.GetString("p4") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p5" && PlayerPrefs.GetString("p5") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p6" && PlayerPrefs.GetString("p6") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p7" && PlayerPrefs.GetString("p7") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p8" && PlayerPrefs.GetString("p8") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p9" && PlayerPrefs.GetString("p9") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p10" && PlayerPrefs.GetString("p10") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p11" && PlayerPrefs.GetString("p11") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p12" && PlayerPrefs.GetString("p12") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p13" && PlayerPrefs.GetString("p13") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p14" && PlayerPrefs.GetString("p14") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p15" && PlayerPrefs.GetString("p15") == "y")
        {
            this.gameObject.SetActive(false);

        }
        else if (this.gameObject.name == "p16" && PlayerPrefs.GetString("p16") == "y")
        {
            this.gameObject.SetActive(false);

        }
    }

}
