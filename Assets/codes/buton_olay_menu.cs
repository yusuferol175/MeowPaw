using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay_menu : MonoBehaviour
{
    public GameObject score_table;
    public GameObject score_siyah;
    public GameObject ev_buton;
    public GameObject play_but;
    public GameObject ses_ac_but;
    public GameObject ses_kapa_but;

    [SerializeField]
    public GameObject fare_but;
    [SerializeField]
    public GameObject balik_but;
    [SerializeField]
    public GameObject lama_but;
    [SerializeField]
    public GameObject balik_buy_but;
    [SerializeField]
    public GameObject lama_buy_but;
    [SerializeField]
    public GameObject solagit_but;
    [SerializeField]
    public GameObject solagit_but_2;
    [SerializeField]
    public GameObject sagagit_but;
    [SerializeField]
    public GameObject sagagit_but_2;
    [SerializeField]
    public GameObject balik_img;
    [SerializeField]
    public GameObject fare_img;
    [SerializeField]
    public GameObject lama_img;
    [SerializeField]
    public GameObject storetable;
    public AudioSource menuses;

    [SerializeField]
    public Text cost;
    public void giris()
    {
        PlayerPrefs.SetInt("bannerdurum", 1);
        SceneManager.LoadScene("oyun");
        
    }
    public void market()
    {
        storetable.gameObject.SetActive(true);
        ev_buton.gameObject.SetActive(true);

        play_but.GetComponent<AudioSource>().Play();
    }
    public void balik_buy()
    {
        if (PlayerPrefs.GetInt("peynirsayisi") >= 1000)
        {
            player.peynirsonuc = PlayerPrefs.GetInt("peynirsayisi") - 1000;
            cost.text = player.peynirsonuc.ToString();
            PlayerPrefs.SetInt("peynirsayisi", player.peynirsonuc);
            PlayerPrefs.SetInt("balik_buy",1);
            balik_buy_but.gameObject.SetActive(false);
            
        }
        
    }
    public void lama_buy()
    {
        if (PlayerPrefs.GetInt("peynirsayisi") >= 1000)
        {
            player.peynirsonuc = PlayerPrefs.GetInt("peynirsayisi") - 1000;
            cost.text = player.peynirsonuc.ToString();
            PlayerPrefs.SetInt("peynirsayisi", player.peynirsonuc);
            PlayerPrefs.SetInt("lama_buy", 1);
            lama_buy_but.gameObject.SetActive(false);

        }

    }
    public void secmek_fare() 
    {
        balik_but.gameObject.SetActive(true);
        lama_but.gameObject.SetActive(true);
        fare_but.gameObject.SetActive(false);
        PlayerPrefs.SetInt("skinid", 0);
    }
    public void secmek_balik()
    {
        fare_but.gameObject.SetActive(true);
        lama_but.gameObject.SetActive(true);
        balik_but.gameObject.SetActive(false);
        PlayerPrefs.SetInt("skinid", 1);

    }
    public void secmek_lama()
    {
        fare_but.gameObject.SetActive(true);
        balik_but.gameObject.SetActive(true);
        lama_but.gameObject.SetActive(false);
        PlayerPrefs.SetInt("skinid", 2);

    }
    public void saga_dogru()
    {
        fare_img.gameObject.SetActive(false);
        balik_img.gameObject.SetActive(true);
        lama_img.gameObject.SetActive(false);
        solagit_but.gameObject.SetActive(true);
        sagagit_but_2.gameObject.SetActive(true);
        sagagit_but.gameObject.SetActive(false);
    }
    public void saga_dogru_2()
    {
        balik_img.gameObject.SetActive(false);
        fare_img.gameObject.SetActive(false);
        lama_img.gameObject.SetActive(true);
        sagagit_but_2.gameObject.SetActive(false);
        solagit_but.gameObject.SetActive(false);
        solagit_but_2.gameObject.SetActive(true);
    }
    public void sola_dogru()
    {
        fare_img.gameObject.SetActive(true);
        balik_img.gameObject.SetActive(false);
        solagit_but.gameObject.SetActive(false);
        sagagit_but_2.gameObject.SetActive(false);
        sagagit_but.gameObject.SetActive(true);
    }
    public void sola_dogru_2()
    {
        fare_img.gameObject.SetActive(false);
        balik_img.gameObject.SetActive(true);
        lama_img.gameObject.SetActive(false);
        solagit_but_2.gameObject.SetActive(false);
        sagagit_but_2.gameObject.SetActive(true);
        solagit_but.gameObject.SetActive(true);
    }
    public void score_board()
    {
        
        score_table.gameObject.SetActive(true);
        score_siyah.gameObject.SetActive(true);
        ev_buton.gameObject.SetActive(true);

        play_but.GetComponent<AudioSource>().Play();
    }
    public void ev()
    {
        score_table.gameObject.SetActive(false);
        score_siyah.gameObject.SetActive(false);
        ev_buton.gameObject.SetActive(false);
        storetable.gameObject.SetActive(false);

        play_but.GetComponent<AudioSource>().Play();
    }

    public void sesikapa_menu()
    {
        menuses.Stop();
        ses_ac_but.gameObject.SetActive(true);
        ses_kapa_but.gameObject.SetActive(false);
    }
    public void sesiac_menu()
    {
        ses_kapa_but.gameObject.SetActive(true);
        ses_ac_but.gameObject.SetActive(false);
        menuses.Play();
    }
    void Start()
    {
        

        score_table = GameObject.Find("score_table");
        score_siyah = GameObject.Find("score_siyah");
        ev_buton = GameObject.Find("ev_buton");
        ses_ac_but = GameObject.Find("sesi_ac_menu");
        ses_kapa_but = GameObject.Find("sesi_kapa_menu");

        score_table.gameObject.SetActive(false);
        score_siyah.gameObject.SetActive(false);
        ev_buton.gameObject.SetActive(false);
        ses_ac_but.gameObject.SetActive(false);
        storetable.gameObject.SetActive(false);

        solagit_but.gameObject.SetActive(false);
        solagit_but_2.gameObject.SetActive(false);
        sagagit_but_2.gameObject.SetActive(false);
        balik_img.gameObject.SetActive(false);
        lama_img.gameObject.SetActive(false);

        play_but = GameObject.Find("giris_buton");


        menuses = GameObject.Find("menu_arka_ses").GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("skinid") == 0)
        {
            fare_but.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("skinid") == 1)
        {
            balik_but.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("skinid") == 2)
        {
            lama_but.gameObject.SetActive(false);
        }



        if (PlayerPrefs.GetInt("balik_buy")==1)
        {
            balik_buy_but.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lama_buy") == 1)
        {
            lama_buy_but.gameObject.SetActive(false);
        }
        cost.text = PlayerPrefs.GetInt("peynirsayisi").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
