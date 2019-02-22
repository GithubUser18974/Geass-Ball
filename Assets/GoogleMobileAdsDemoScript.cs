using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class GoogleMobileAdsDemoScript : MonoBehaviour {
    private BannerView bannerView;
    
    public void Start()
    {
            string appId = "ca-app-pub-9336535284372672~3683798567";



        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        this.RequestBanner();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "UI")
        {
            bannerView.Destroy();
        }
    }
    private void RequestBanner()
    {
            string adUnitId = "ca-app-pub-9336535284372672/6118390210";


        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

 

}
