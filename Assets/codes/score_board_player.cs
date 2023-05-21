using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_board_player : MonoBehaviour
{
    public GameObject row_player;
    public GameObject row_ant;
    public GameObject row_rat;
    public GameObject row_goose;
    public GameObject row_fish;
    public GameObject row_squr;
    public GameObject row_king;
    public GameObject row_whale;
    public GameObject row_ocean;
    public GameObject row_uni;
    public GameObject row_master;

    public Text score_menu;
    

    public Vector3 score_menu_last;
    public Vector3 score_ant_last;
    public Vector3 score_rat_last;
    public Vector3 score_goose_last;
    public Vector3 score_fish_last;
    public Vector3 score_squr_last;
    public Vector3 score_king_last;
    public Vector3 score_king_whale;
    public Vector3 score_king_ocean;
    public Vector3 score_king_uni;
    public Vector3 score_king_master;
    // Start is called before the first frame update
    void Start()
    {
        
        //PlayerPrefs.DeleteAll();
        score_menu.text = PlayerPrefs.GetInt("skor").ToString();

        
        score_menu_last = row_player.gameObject.transform.position;
        score_ant_last = row_ant.gameObject.transform.position;
        score_rat_last = row_rat.gameObject.transform.position;
        score_goose_last = row_goose.gameObject.transform.position;
        score_fish_last = row_fish.gameObject.transform.position;
        score_squr_last = row_squr.gameObject.transform.position;
        score_king_last = row_king.gameObject.transform.position;
        score_king_whale = row_whale.gameObject.transform.position;
        score_king_ocean = row_ocean.gameObject.transform.position;
        score_king_uni = row_uni.gameObject.transform.position;
        score_king_master = row_master.gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (100 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 500)
        {
            
            row_player.gameObject.transform.position = score_ant_last;
            row_ant.gameObject.transform.position = score_menu_last;

        }
        if (500 < PlayerPrefs.GetInt("skor")&& PlayerPrefs.GetInt("skor") < 1000)
        {
            row_player.gameObject.transform.position = score_rat_last;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;

        }
        if (1000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 3000)
        {
            row_player.gameObject.transform.position = score_goose_last;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            

        }
        if (3000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 5000)
        {
            row_player.gameObject.transform.position = score_fish_last;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;


        }
        if (5000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 7000)
        {
            row_player.gameObject.transform.position = score_squr_last;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;
            row_squr.gameObject.transform.position = score_fish_last;


        }
        if (7000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 10000)
        {
            row_player.gameObject.transform.position = score_king_last;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;
            row_squr.gameObject.transform.position = score_fish_last;
            row_king.gameObject.transform.position = score_squr_last;


        }
        if (10000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 15000)
        {
            row_player.gameObject.transform.position = score_king_whale;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;
            row_squr.gameObject.transform.position = score_fish_last;
            row_king.gameObject.transform.position = score_squr_last;
            row_whale.gameObject.transform.position = score_king_last;


        }
        if (15000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 18000)
        {
            row_player.gameObject.transform.position = score_king_ocean;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;
            row_squr.gameObject.transform.position = score_fish_last;
            row_king.gameObject.transform.position = score_squr_last;
            row_whale.gameObject.transform.position = score_king_last;
            row_ocean.gameObject.transform.position = score_king_whale;


        }
        if (18000 < PlayerPrefs.GetInt("skor") && PlayerPrefs.GetInt("skor") < 20000)
        {
            row_player.gameObject.transform.position = score_king_uni;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;
            row_squr.gameObject.transform.position = score_fish_last;
            row_king.gameObject.transform.position = score_squr_last;
            row_whale.gameObject.transform.position = score_king_last;
            row_ocean.gameObject.transform.position = score_king_whale;
            row_uni.gameObject.transform.position = score_king_ocean;


        }
        if (20000 < PlayerPrefs.GetInt("skor") )
        {
            row_player.gameObject.transform.position = score_king_master;
            row_ant.gameObject.transform.position = score_menu_last;
            row_rat.gameObject.transform.position = score_ant_last;
            row_goose.gameObject.transform.position = score_rat_last;
            row_fish.gameObject.transform.position = score_goose_last;
            row_squr.gameObject.transform.position = score_fish_last;
            row_king.gameObject.transform.position = score_squr_last;
            row_whale.gameObject.transform.position = score_king_last;
            row_ocean.gameObject.transform.position = score_king_whale;
            row_uni.gameObject.transform.position = score_king_ocean;
            row_master.gameObject.transform.position = score_king_uni;


        }

    }
}
