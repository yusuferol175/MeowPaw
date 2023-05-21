using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonsuz_map : MonoBehaviour
{
    [SerializeField]
    public GameObject platform;
    [SerializeField]
    public GameObject peynir;
    [SerializeField]
    public GameObject kapan;
    [SerializeField]
    public GameObject lama_kapan;
    [SerializeField]
    public GameObject balik_kapan;
    [SerializeField]
    public GameObject mapci;
    [SerializeField]
    public GameObject arkaplanbulut;
    [SerializeField]
    public GameObject arkaplanuzay;
    [SerializeField]
    public GameObject kedipence;


    public float lastpos_plat_x;
    public float lastpos_plat_y;
    public float lastpos_plat_z;
    public float lastpos_map_y;
    public float lastpos_pence_y;
    public float lastpos_pence_x;
    public float lastpos_peynir_x;


  


    

    public int sonuc;
    public bool olustur = false;
    // Start is called before the first frame update
    void Start()
    {
        
        lastpos_plat_x = transform.position.x;
        lastpos_plat_y = transform.position.y;
        lastpos_map_y = transform.position.y+116;
        lastpos_pence_y = transform.position.y+30;
        lastpos_pence_x = transform.position.x;
        lastpos_plat_z = transform.position.z;
        

         

        System.Random random = new System.Random();
        for (int i = 1; i < 100; i++)
            {
            


                Instantiate(platform, new Vector3(lastpos_plat_x, lastpos_plat_y, 0f), transform.rotation);
                lastpos_plat_x = transform.position.x+ (float)(random.NextDouble() * (3.15 - -3.15) + -3.15);
                
                
                
                lastpos_plat_y = transform.position.y + i*2f;
                lastpos_plat_z = transform.position.z;
                
                lastpos_peynir_x = (float)(random.NextDouble() * ((lastpos_plat_x - 1) - (lastpos_plat_x + 1)) + (lastpos_plat_x + 1));


            sonuc = random.Next(0, 9);

            if (lastpos_peynir_x <= 2.5f&&lastpos_peynir_x>=-2.5f)
            {
                if (sonuc == 1 || sonuc == 3)
                {
                    Instantiate(peynir, new Vector3(lastpos_peynir_x, lastpos_plat_y + 1f, -1f), transform.rotation);
                }
            }



            if (lastpos_peynir_x <= 2.5f && lastpos_peynir_x >= -2.5f)
            {

                if (sonuc == 2 || sonuc == 4 )
            {

                    if (PlayerPrefs.GetInt("skinid") == 0)
                    {
                        Instantiate(kapan, new Vector3(lastpos_peynir_x, lastpos_plat_y + 0.48f, -1f), kapan.transform.rotation);
                    }
                    if (PlayerPrefs.GetInt("skinid") == 1)
                    {
                        Instantiate(balik_kapan, new Vector3(lastpos_peynir_x, lastpos_plat_y + 0.48f, -1f), balik_kapan.transform.rotation);
                    }
                    if (PlayerPrefs.GetInt("skinid") == 2)
                    {
                        Instantiate(lama_kapan, new Vector3(lastpos_peynir_x, lastpos_plat_y + 0.48f, -1f), lama_kapan.transform.rotation);
                    }
                
            }
            }
            if (i == 99)
            {

                Instantiate(mapci, new Vector3(mapci.transform.position.x, lastpos_plat_y -20f, -1f), mapci.transform.rotation);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            Instantiate(arkaplanbulut, new Vector3(arkaplanbulut.transform.position.x,lastpos_map_y+18f, 5), Quaternion.identity);
            lastpos_map_y = lastpos_map_y + 30f;
        }

        for (int i = 0; i < 10; i++)
        {
            Instantiate(kedipence,new Vector3(lastpos_pence_x,lastpos_pence_y,kedipence.transform.position.z),Quaternion.identity);
            lastpos_pence_y = lastpos_pence_y + 40f;
            lastpos_pence_x = transform.position.x + (float)(random.NextDouble() * (2.15 - -2.15) + -2.15);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (player.map_olustur)
        {
            
            System.Random random = new System.Random();
            for (int i = 0; i < 100; i++)
            {


                Instantiate(platform, new Vector3(lastpos_plat_x, lastpos_plat_y, 0f), transform.rotation);
                lastpos_plat_x = transform.position.x+ (float)(random.NextDouble() * (3.15 - -3.15) + -3.15);

                lastpos_peynir_x = (float)(random.NextDouble() * ((lastpos_plat_x - 1) - (lastpos_plat_x + 1)) + (lastpos_plat_x + 1));

                lastpos_plat_y = lastpos_plat_y + 2f;
                

                sonuc = random.Next(0, 9);
                if (lastpos_peynir_x <= 2.5f && lastpos_peynir_x >= -2.5f)
                {
                    if (sonuc == 1 || sonuc == 3)
                    {
                        Instantiate(peynir, new Vector3(lastpos_peynir_x, lastpos_plat_y + 1f, -1f), transform.rotation);
                    }
                }



                if (lastpos_peynir_x <= 2.5f && lastpos_peynir_x >= -2.5f)
                {

                    if (sonuc == 2 || sonuc == 4 || sonuc==6)
                    {
                        if (PlayerPrefs.GetInt("skinid") == 0)
                        {
                            Instantiate(kapan, new Vector3(lastpos_peynir_x, lastpos_plat_y + 0.48f, -1f), kapan.transform.rotation);
                        }
                        if (PlayerPrefs.GetInt("skinid") == 1)
                        {
                            Instantiate(balik_kapan, new Vector3(lastpos_peynir_x, lastpos_plat_y + 0.48f, -1f), balik_kapan.transform.rotation);
                        }
                        if (PlayerPrefs.GetInt("skinid") == 2)
                        {
                            Instantiate(lama_kapan, new Vector3(lastpos_peynir_x, lastpos_plat_y + 0.48f, -1f), lama_kapan.transform.rotation);
                        }
                    }
                }

                if (i == 99)
                {
                   
                    Instantiate(mapci, new Vector3(mapci.transform.rotation.x, lastpos_plat_y - 20f, -1f), mapci.transform.rotation);
                }

            }
            
            for (int i = 0; i < 6; i++)
            {
                Instantiate(arkaplanuzay, new Vector3(arkaplanuzay.transform.position.x, lastpos_map_y + 22f, 5), Quaternion.identity);
                lastpos_map_y = lastpos_map_y + 37f;
            }
            for (int i = 0; i < 10; i++)
            {
                Instantiate(kedipence, new Vector3(lastpos_pence_x, lastpos_pence_y, kedipence.transform.position.z), Quaternion.identity);
                lastpos_pence_y = lastpos_pence_y + 40f;
                lastpos_pence_x = transform.position.x + (float)(random.NextDouble() * (2.15 - -2.15) + -2.15);
            }
            player.map_olustur = false;
        }

    }
}
