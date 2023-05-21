using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay : MonoBehaviour
{
    public GameObject pause;
    
    public GameObject ses_ac_but;
    public GameObject ses_kapa_but;

    public float MovementSpeed = 1;
    public static bool hareket;
    public bool oyundurdumu = false;
    public bool oldumu = false;
    public bool sesolayi = true;



    AudioSource oyunses;
    AudioSource buton_bas;
    [SerializeField]
    AudioClip meow;
    [SerializeField]
    AudioClip jump_sound;
    public void sesikapa_oyn()
    {
        PlayerPrefs.SetString("sesvarmi", "var");
        oyunses.Stop();
        ses_ac_but.gameObject.SetActive(true);
        ses_kapa_but.gameObject.SetActive(false);
        
    }
    public void sesiac_oyn()
    {
        PlayerPrefs.SetString("sesvarmi", "yok");
        ses_kapa_but.gameObject.SetActive(true);
        ses_ac_but.gameObject.SetActive(false);
        oyunses.Play();
        
    }
    public void giris()
    {
        SceneManager.LoadScene("oyun");

    }

    public void zipla()
    {
        if (player.fare.gameObject)
        {
           
            if (player.kapildimi==false)
            {
                if (player.yerdemi)
                {
                    buton_bas.PlayOneShot(jump_sound);
                    player.fare_rigid.AddForce(new Vector2(0, player.JumpForce * 10), ForceMode2D.Impulse);
                    
                }
            }
            
            
        }
        
    }
    public void move_start(bool sol_da_mi)
    {
        if (sol_da_mi)
        {
            if (player.fare.transform.localScale.x > 0)
            {
                player.fare.transform.localScale = new Vector3(player.fare.transform.localScale.x * -1, player.fare.transform.localScale.y, player.fare.transform.localScale.x);
                MovementSpeed *= -1;
            }

            
        }
        else
        {
            if (player.fare.transform.localScale.x < 0)
            {
                player.fare.transform.localScale = new Vector3(player.fare.transform.localScale.x * -1, player.fare.transform.localScale.y, player.fare.transform.localScale.x);
                MovementSpeed *= -1;
            }

            
        }

        hareket = true;
    }
    public void move_stop()
    {
        hareket = false;

    }
    public void pausebuton()
    {

        if (oyundurdumu == false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }

        buton_bas.PlayOneShot(meow);
        pause.gameObject.SetActive(true);

    }
    public void oyunudurdur()
    {
        buton_bas.PlayOneShot(meow);
        if (oyundurdumu == true)
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
        pause.gameObject.SetActive(false);
        oldumu = false;
    }
    public void restartbuton()
    {

        SceneManager.LoadScene("oyun");

    }
    public void menubuton()
    {
        if (PlayerPrefs.GetInt("skor") < (int)score.skor)
        {
            PlayerPrefs.SetInt("skor", (int)score.skor);
        }
        PlayerPrefs.SetInt("bannerdurum", 0);
        SceneManager.LoadScene("menu");


    }

    // Start is called before the first frame update
    void Start()
    {
        

        hareket = false;
        player.yerdemi = true;

        buton_bas = GetComponent<AudioSource>();

        pause = GameObject.Find("pause");
        

        ses_ac_but = GameObject.Find("sesi_ac_oyn");
        ses_kapa_but = GameObject.Find("sesi_kapa_oyn");

        ses_ac_but.gameObject.SetActive(false);

        oyunses = GameObject.Find("arka_plan_ses").GetComponent<AudioSource>();

        if (player.fare.gameObject!=null)
        {
            pause.gameObject.SetActive(false);

            if (sesolayi==true)
            {
                oyunses.Play();
                sesolayi = false;

            }
            if (PlayerPrefs.GetString("sesvarmi") == "var")
            {
               
                ses_ac_but.gameObject.SetActive(true);
                ses_kapa_but.gameObject.SetActive(false);

                oyunses.Stop();
            }
            if (PlayerPrefs.GetString("sesvarmi") == "yok")
            {
               
                ses_kapa_but.gameObject.SetActive(true);
                ses_ac_but.gameObject.SetActive(false);

                oyunses.Play();
            }
        }
        
        Time.timeScale = 1f;
        player.kapildimi = false;

        oldumu = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetString("sesvarmi"));

        if (player.fare.gameObject!=null)
        {
            if (player.yerdemi == false)
            {
                player.animkar.SetBool("havada", true);
            }
            else
            {
                player.animkar.SetBool("havada", false);
            }
        }

        if (hareket)
        {
            if (player.kapildimi==false)
            {
                if (player.fare.gameObject != null)
                {

                    player.fare.transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime * 5;
                    

                    player.animkar.SetBool("haraket", true);
                }
            }
            else
            {
                player.animkar.SetBool("haraket", false);
            }


        }
        else
        {
            player.animkar.SetBool("haraket", false);
        }


       

    }

}
