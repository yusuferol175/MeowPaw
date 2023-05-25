using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class olum_score : MonoBehaviour
{
    public Text scoretext_olum;
    public Text scoretext;


    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = ((int)score.skor).ToString();
        if (PlayerPrefs.GetInt("skor") < (int)score.skor)
        {

            PlayerPrefs.SetInt("skor", (int)score.skor);
            scoretext_olum.text = ((int)score.skor).ToString();
        }
        else
        {

            scoretext_olum.text = PlayerPrefs.GetInt("skor").ToString();
        }
    }

}
