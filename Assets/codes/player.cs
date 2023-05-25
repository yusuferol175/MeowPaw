using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class player : MonoBehaviour
{
    public static Rigidbody2D fare_rigid;
    public static GameObject fare;
    public static GameObject paw_glg;
    public static GameObject pencetrig;

    [SerializeField]
    public GameObject tkplkmr;

    public static float JumpForce = 1;

    public static bool yerdemi;
    public static bool map_olustur=false;
    public static bool kapildimi;
    public static bool penceharaket=false;
    public static Animator animkap;
    public static Animator animkar;
    AudioSource pence_bas;
    [SerializeField]
    AudioClip pence_sound;
    [SerializeField]
    AudioClip peynir_sound;
    [SerializeField]
    public GameObject balik;
    [SerializeField]
    public GameObject faresk;
    [SerializeField]
    public GameObject lama;

    public static int peynirsonuc ;
    void duzelt()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        kapildimi = false;
        
    }
    void penceses()
    {
        pence_bas.PlayOneShot(pence_sound);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="peynir")
        {
            peynirsonuc = peynirsonuc + 1;
            PlayerPrefs.SetInt("peynirsayisi", peynirsonuc);
            pence_bas.PlayOneShot(peynir_sound);
            score.skor += 50;
            Destroy(collision.gameObject);
           
        }
        if (collision.gameObject.tag=="kapan")
        {
            
            if (collision.gameObject.GetComponent<Animator>().GetBool("kapandimi") == false)
            {
                
                GetComponent<SpriteRenderer>().color = Color.red;
                kapildimi = true;
                Invoke("duzelt", 1f);
            }
            collision.gameObject.GetComponent<Animator>().SetBool("kapandimi",true);
            
            
            
        }
        
            
            if (collision.gameObject.tag == "paw")
            {
                    Invoke("penceses", 1f);
                    
                    Instantiate(paw.pawc,collision.gameObject.transform.position,Quaternion.identity);
                    Destroy(collision.gameObject);
            }
        if (collision.gameObject.tag=="map")
        {
            Destroy(collision.gameObject);
            map_olustur = true;
        }
    }

    
    void Start()
    {
        var vcam = tkplkmr.GetComponent<CinemachineVirtualCamera>();
        if (PlayerPrefs.GetInt("skinid") == 0)
        {
            fare = faresk;
            balik.gameObject.SetActive(false);
            lama.gameObject.SetActive(false);
            vcam.Follow = faresk.transform;
        }
        if (PlayerPrefs.GetInt("skinid") == 1)
        {
            fare = balik;
            faresk.gameObject.SetActive(false);
            lama.gameObject.SetActive(false);
            vcam.Follow = balik.transform;
        }
        if (PlayerPrefs.GetInt("skinid") == 2)
        {
            fare = lama;
            faresk.gameObject.SetActive(false);
            balik.gameObject.SetActive(false);
            vcam.Follow = lama.transform;
        }


        pence_bas = GameObject.Find("buton_olay_oyun").GetComponent<AudioSource>();

        animkar = fare.GetComponent<Animator>();


        score.skor = 0;
        fare_rigid = GetComponent<Rigidbody2D>();
        

        peynirsonuc = PlayerPrefs.GetInt("peynirsayisi");
       
    }

}
