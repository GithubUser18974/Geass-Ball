using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIButtonLevelLoad : MonoBehaviour
{
	
	
	public void loadLevel() {
    
            SceneManager.LoadScene("Infinity");
     
    }
        	
	public void loadLevelBGS()
    {

        PlayerPrefs.SetString("bgsong", "s");
        SceneManager.LoadScene("Infinity");

    }

    public void loadLevelUI()
    {

        SceneManager.LoadScene("UI");

    }
    public static void ShowVedioAds()
    {
        GoogleMobileVedioAds.Instance.ShowVedio();
    }

}
