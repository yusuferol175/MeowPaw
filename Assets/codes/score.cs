using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    
    
    public static float skor;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        
    }

    
    void Update()
    {
        
        if (player.fare.gameObject!=null)
        {
            
                skor += 1 * Time.deltaTime;
                scoretext.text = ((int)skor).ToString();

            
            
            
        }
        

        
    }
}
