using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIButtonBuyBall : MonoBehaviour {
    public GameObject panel;
    public Text mText;
    public Text Diamond;
 
    public void BuyPlayerB1() {
        if (PlayerPrefs.GetInt("dia") >= 30&&this.gameObject.tag=="notbuy")
        {
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia")-30);
            PlayerPrefs.SetString("p1", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB1");
            this.gameObject.tag ="but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
            Debug.Log("BOUGHT");
        }
        else if(this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p1", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB1");

        }
    }
    public void BuyPlayerB2()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p2", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB2");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p2", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB2");
        }
    }
    public void BuyPlayerB3()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p3", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB3");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p3", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB3");
        }
    }
    public void BuyPlayerB4()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p4", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB4");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p4", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB4");
        }
    }
    public void BuyPlayerB5()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p5", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB5");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p5", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB5");
        }
    }
    public void BuyPlayerB6()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p6", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB6");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p6", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB6");
        }
    }
    public void BuyPlayerB7()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p7", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB7");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p7", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB7");
        }
    }
    public void BuyPlayerB8()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p8", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB8");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p8", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB8");
        }
    }
    public void BuyPlayerB9()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p9", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB9");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p9", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB9");
        }
    }
    public void BuyPlayerB10()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p10", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB10");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p10", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB10");
        }
    }
    public void BuyPlayerB11()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p11", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB11");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p11", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB11");
        }
    }
    public void BuyPlayerB12()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p12", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB12");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p12", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB12");
        }
    }
    public void BuyPlayerB13()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p13", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB13");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p13", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB13");
        }
    }
    public void BuyPlayerB14()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p14", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB14");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p14", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB14");
        }
    }
    public void BuyPlayerB15()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p15", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB15");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p15", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB15");
        }
    }
    public void BuyPlayerB16()
    {
        if (PlayerPrefs.GetInt("dia") >= 30 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("p16", "y");
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 30);
            PlayerPrefs.SetString("mplayer", "PlayerB16");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            mText.text = "";
        }
        else if (this.gameObject.tag == "but")
        {
            PlayerPrefs.SetString("p16", "y");
            PlayerPrefs.SetString("mplayer", "PlayerB16");
        }
    }
    public void BuySong1()
    {
        if (PlayerPrefs.GetInt("dia") >= 20 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("s1", "yes");

            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 20);
            PlayerPrefs.SetString("bgsong", "s1");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            panel.gameObject.tag = "but";
            SceneManager.LoadScene("Infinity");

        }
        else if (PlayerPrefs.GetString("s1") == "yes")
        {
            PlayerPrefs.SetString("s1", "yes");

            PlayerPrefs.SetString("bgsong", "s1");
            panel.gameObject.tag = "but";
            SceneManager.LoadScene("Infinity");


        }
    }
    public void BuySong2()
    {
        if (PlayerPrefs.GetInt("dia") >= 20 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("s2", "yes");

            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 20);
            PlayerPrefs.SetString("bgsong", "s2");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            panel.gameObject.tag = "but";
            SceneManager.LoadScene("Infinity");

        }
        else if (PlayerPrefs.GetString("s2") == "yes")
        {
            PlayerPrefs.SetString("s2", "yes");

            PlayerPrefs.SetString("bgsong", "s2");
            panel.gameObject.tag = "but";
            SceneManager.LoadScene("Infinity");


        }
    }
    public void BuySong3()
    {
        if (PlayerPrefs.GetInt("dia") >= 20 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetString("s3", "yes");

            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 20);
            PlayerPrefs.SetString("bgsong", "s3");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            panel.gameObject.tag = "but";
            SceneManager.LoadScene("Infinity");

        }
        else if (PlayerPrefs.GetString("s3")=="yes")
        {
            PlayerPrefs.SetString("s3", "yes");

            PlayerPrefs.SetString("bgsong", "s3");
            panel.gameObject.tag = "but";
            SceneManager.LoadScene("Infinity");


        }
    }
    public void BuySong4()
    {
        if (PlayerPrefs.GetInt("dia") >= 20 && this.gameObject.tag == "notbuy")
        {
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") - 20);
            PlayerPrefs.SetString("bgsong", "s4");
            this.gameObject.tag = "but";
            Diamond.text = "" + PlayerPrefs.GetInt("dia");
            panel.SetActive(false);
            PlayerPrefs.SetString("s4", "yes");
            SceneManager.LoadScene("Infinity");

        }
        else if (PlayerPrefs.GetString("s4") == "yes")
        {
            PlayerPrefs.SetString("bgsong", "s4");
            panel.gameObject.tag = "but";
            PlayerPrefs.SetString("s4", "yes");

            SceneManager.LoadScene("Infinity");



        }
    }
}
