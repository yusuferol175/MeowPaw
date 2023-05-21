using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kedi_haller : MonoBehaviour
{
    public static bool oldu=false;
    public static int olumcount;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            
            SceneManager.LoadScene("olum_ekran");
            olumcount = PlayerPrefs.GetInt("olumsayisi") + 1;
            PlayerPrefs.SetInt("olumsayisi", olumcount);
           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, 2f*Time.deltaTime, 0);
    }
}
