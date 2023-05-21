using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class gecis_ad_sc : MonoBehaviour
{
    private InterstitialAd reklamObjesi;
    private InterstitialAd gecis;
    void Start()
    {

        MobileAds.Initialize(reklamDurumu => { });
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
        reklamObjesi = new InterstitialAd("ca-app-pub-3940256099942544/1033173712");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        reklamObjesi.LoadAd(reklamIstegi);

        if (PlayerPrefs.GetInt("olumsayisi") == 3 || PlayerPrefs.GetInt("olumsayisi") == 6 || PlayerPrefs.GetInt("olumsayisi") == 9)
        {
            StartCoroutine(ReklamiGoster());
        }
        
    }
    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;
        reklamObjesi.Show();
    }
    void OnDestroy()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
    }
}
