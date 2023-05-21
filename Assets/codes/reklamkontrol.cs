using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;
using UnityEngine.SceneManagement;

public class reklamkontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public Button reklams;

    private RewardedAd rewardedAd;


    public int reklampeynir;

    public GameObject peyniral_but;
    // Start is called before the first frame update
    public void Start()
    {
        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
        
    }

 

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
       
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
       
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
       
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        reklampeynir = PlayerPrefs.GetInt("peynirsayisi") + 20;
        PlayerPrefs.SetInt("peynirsayisi", reklampeynir);
        peyniral_but.SetActive(false);
    }

    private void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    void Update()
    {
        
    }
}
