using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddmobManager : MonoBehaviour
{
    #region 필드

    static AddmobManager instance;
    const string bannerTestID = "ca-app-pub-3940256099942544/6300978111";
    BannerView bannerAd;

    #endregion

    #region 속성

    public static AddmobManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AddmobManager>();
                if (instance == null) instance = new GameObject("AddmobManager", typeof(AddmobManager)).GetComponent<AddmobManager>();
            }

            return instance;
        }
    }

    AdRequest AdRequest => new AdRequest.Builder().Build();

    #endregion

    #region 유니티 생명주기

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        var requestConfiguration = new RequestConfiguration
        .Builder()
        .build();

        MobileAds.SetRequestConfiguration(requestConfiguration);

        string bannerID = bannerTestID;

        bannerAd = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);
        bannerAd.LoadAd(AdRequest);

        ToggleBannerAd(false);
    }

    public void ToggleBannerAd(bool toggle)
    {
        if (toggle) bannerAd.Show();
        else bannerAd.Hide();
    }

    #endregion
}
