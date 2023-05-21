using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skin_degis : MonoBehaviour
{
    [SerializeField]
    public GameObject arkpln1;
    [SerializeField]
    public Sprite arkplnbalik1;
    [SerializeField]
    public Sprite arkplnlama1;
    [SerializeField]
    public GameObject arkpln2;
    [SerializeField]
    public Sprite arkplnbalik2;
    [SerializeField]
    public Sprite arkplnlama2;
    [SerializeField]
    public GameObject arkpln3;
    [SerializeField]
    public Sprite arkplnbalik3;
    [SerializeField]
    public Sprite arkplnlama3;
    [SerializeField]
    public GameObject arkpln4;
    [SerializeField]
    public Sprite arkplnbalik4;
    [SerializeField]
    public Sprite arkplnlama4;
    [SerializeField]
    public GameObject arkpln5;
    [SerializeField]
    public Sprite arkplnbalik5;
    [SerializeField]
    public Sprite arkplnlama5;
    [SerializeField]
    public Sprite arkplnbulut;
    [SerializeField]
    public GameObject arkpln6;
    [SerializeField]
    public Sprite arkplnbalik6;
    [SerializeField]
    public Sprite arkplnlama6;
    [SerializeField]
    public Sprite arkplnuzay;


    [SerializeField]
    public GameObject kedi_fare;
    [SerializeField]
    public Sprite kedi_balik;
    [SerializeField]
    public Sprite kedi_lama;

    [SerializeField]
    public GameObject platform_fare;
    [SerializeField]
    public Sprite platform_balik;
    [SerializeField]
    public Sprite platform_lama;
    [SerializeField]
    public Sprite platform_fare_sprite;

    [SerializeField]
    public GameObject peynir_yem;
    [SerializeField]
    public Sprite balik_yem;
    [SerializeField]
    public Sprite fare_yem;
    [SerializeField]
    public Sprite lama_yem;

    [SerializeField]
    public GameObject paw_obje;
    [SerializeField]
    public Sprite paw_balik;
    [SerializeField]
    public Sprite paw_fare;
    [SerializeField]
    public Sprite paw_lama;

    [SerializeField]
    public GameObject baslangis_obje;
    [SerializeField]
    public Sprite lama_basla;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("skinid") == 0)
        {
            arkpln5.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbulut;
            arkpln6.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnuzay;

            platform_fare.gameObject.GetComponent<SpriteRenderer>().sprite = platform_fare_sprite;
            peynir_yem.gameObject.GetComponent<SpriteRenderer>().sprite = fare_yem;
            paw_obje.gameObject.GetComponent<SpriteRenderer>().sprite = paw_fare;
        }
        if (PlayerPrefs.GetInt("skinid") == 1)
        {
            arkpln1.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbalik1;
            arkpln2.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbalik2;
            arkpln3.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbalik3;
            arkpln4.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbalik4;
            arkpln5.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbalik5;
            arkpln6.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnbalik6;

            kedi_fare.gameObject.GetComponent<SpriteRenderer>().sprite = kedi_balik;
            platform_fare.gameObject.GetComponent<SpriteRenderer>().sprite = platform_balik;
            peynir_yem.gameObject.GetComponent<SpriteRenderer>().sprite = balik_yem;
            paw_obje.gameObject.GetComponent<SpriteRenderer>().sprite = paw_balik;
        }
        if (PlayerPrefs.GetInt("skinid") == 2)
        {
            arkpln1.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnlama1;
            arkpln2.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnlama2;
            arkpln3.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnlama3;
            arkpln4.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnlama4;
            arkpln5.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnlama5;
            arkpln6.gameObject.GetComponent<SpriteRenderer>().sprite = arkplnlama6;

            baslangis_obje.gameObject.GetComponent<SpriteRenderer>().sprite = lama_basla;

            kedi_fare.gameObject.GetComponent<SpriteRenderer>().sprite = kedi_lama;
            platform_fare.gameObject.GetComponent<SpriteRenderer>().sprite = platform_lama;
            peynir_yem.gameObject.GetComponent<SpriteRenderer>().sprite = lama_yem;
            paw_obje.gameObject.GetComponent<SpriteRenderer>().sprite = paw_lama;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
