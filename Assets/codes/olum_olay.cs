using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;
public class olum_olay : MonoBehaviour
{
    [SerializeField]
    public GameObject peyniral_but;
    public void restartbuton()
    {
        if (PlayerPrefs.GetInt("reklamvar")==1)
        {

        }
        else
        {
            SceneManager.LoadScene("oyun");
        }
        

    }
    public void menubuton()
    {
        
        if (PlayerPrefs.GetInt("reklamvar") == 1)
        {

        }
        else
        {
            if (PlayerPrefs.GetInt("skor") < (int)score.skor)
            {
                PlayerPrefs.SetInt("skor", (int)score.skor);
            }

            PlayerPrefs.SetInt("bannerdurum", 0);
            SceneManager.LoadScene("menu");
        }
        


    }
    
    public void reklamvar()
    {
        PlayerPrefs.SetInt("reklamvar", 0);
    }
    void Start()
    {

        if (PlayerPrefs.GetInt("olumsayisi") == 3 || PlayerPrefs.GetInt("olumsayisi") == 6 || PlayerPrefs.GetInt("olumsayisi") == 9)
        {
            PlayerPrefs.SetInt("reklamvar", 1);
            Invoke("reklamvar", 1f);
        }

        

        if (PlayerPrefs.GetInt("olumsayisi")==10)
        {
            
            peyniral_but.SetActive(true);
            PlayerPrefs.SetInt("olumsayisi", 0);
        }
        else
        {
            peyniral_but.SetActive(false);
        }

        
    }

}
