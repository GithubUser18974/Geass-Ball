using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleMobileVedioAds : MonoBehaviour {

    public static GoogleMobileVedioAds Instance { set; get; }
    InterstitialAd interstitial;

    public void Start()
    {
        string appId = "ca-app-pub-9336535284372672~3683798567";


        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.RequestInterstitial();
    }
    private void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-9336535284372672/3628900198";


        // Initialize an InterstitialAd.
         interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }
    public  void ShowVedio()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") + 5);

        }
    }
}
