using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using GoogleMobileAds.Api;

public class GameOver : MonoBehaviour
{
    float timer;
    public string SceneMenu;
    // [SerializeField] private string appID;
    // [SerializeField] private string InterstisialID;
    // InterstitialAd interstisial;
    // private void Awake()
    // {
    //     MobileAds.Initialize(appID);
    //     RequestInterstisial();
    // }

    // Use this for initialization
    void Start()
    {
        // ShowInterstisialAD();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            SceneManager.LoadScene(SceneMenu);
        }
    }
    // public void ShowInterstisialAD()
    // {
    //     if (interstisial.IsLoaded())
    //     {
    //         interstisial.Show();
    //     }
    // }
    // private void RequestInterstisial()
    // {
    //     interstisial = new InterstitialAd(InterstisialID);
    //     interstisial.OnAdClosed += Interstitial_onAdClosed;

    //     AdRequest request = new AdRequest.Builder().Build();
    //     interstisial.LoadAd(request);

    // }
    // private void Interstitial_onAdClosed(object sender, System.EventArgs e)
    // {
    //     RequestInterstisial();
    // }
}
