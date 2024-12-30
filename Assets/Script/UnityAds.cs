//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.Advertisements;

//public class UnityAds : MonoBehaviour
//{
//    string placementId= "video";
//    int timer=5;
    
//  #if UNITY_IOS
//  private string gameId = "3115984";
 
//#elif UNITY_ANDROID
//  private string gameId = "3115985";
//#endif

//    // Start is called before the first frame update
//    void Start()
//    {
//    if (Advertisement.isSupported)
//        {
//            Advertisement.Initialize(gameId, true);
//        }
//        StartCoroutine(MulaiIklanInterstisial());
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    IEnumerator MulaiIklanInterstisial()
//    {
//        yield return new WaitForSeconds(timer);
//        ShowAd();
//        timer = 61;
//        StartCoroutine(MulaiIklanInterstisial()); 
//    }             

//    void ShowAd(){
//        // menampilkan iklan
//        ShowOptions options = new ShowOptions();
//        options.resultCallback = HandleShowResult;
//        Advertisement.Show(placementId, options);

//    }
//        void HandleShowResult(ShowResult result)
//    {
//        // merespon feedback, jika berhasil maka coin akan ditambah 50
//        if (result == ShowResult.Finished)
//        {
//            Debug.Log("Video selesai - tawarkan coin ke pemain");
//            // coin += 50;
//            // txCoin.text = "Coin: " + coin;
//        }
//        else if (result == ShowResult.Skipped)
//        {
//            Debug.LogWarning("Video dilewati - tidak menawarkan coin ke pemain");
//        }
//        else if (result == ShowResult.Failed)
//        {
//            Debug.LogError("Video tidak ditampilkan");
//        }
//    }

//}
