using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inputfieldmanager : MonoBehaviour
{
    public GameObject Confirm;

    public Text player_1;
    public Text player_2;
    public Text player_3;
    public Text player_4;
    public Text player_5;
    public Text player_6;
    public Text player_7;
    public Text player_8;
    public Text player_9;
    public Text player_10;


    public InputField Team1;
    public InputField Team2;
/*============1티어============*/
    public InputField Team3;
    public InputField Team4;
/*============2티어============*/
    public InputField Team5;
    public InputField Team6;
/*============3티어============*/
    public InputField Team7;
    public InputField Team8;
/*============4티어============*/
    public InputField Team9;
    public InputField Team10;
/*============5티어============*/

    public int Team_tear_1;
    public int Team_tear_2;
    public int Team_tear_3;
    public int Team_tear_4;
    public int Team_tear_5;
    void Start()
    {
        Confirm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        Team_tear_1 = Random.Range(1,3);
        Team_tear_2 = Random.Range(1,3);
        Team_tear_3 = Random.Range(1,3);
        Team_tear_4 = Random.Range(1,3);
        Team_tear_5 = Random.Range(1,3);

    }

    public void Team_1()
    {

        Confirm.SetActive(true);

        if(Team_tear_1 <= 1)
        {
            player_1.text = Team1.text;
            player_2.text = Team2.text;
        }
        else
        {
            player_2.text = Team1.text;
            player_1.text = Team2.text;
        }
        /*===공백==*/
        if(Team_tear_2 <= 1)
        {
            player_3.text = Team3.text;
            player_4.text = Team4.text;
        }
        else
        {
            player_4.text = Team3.text;
            player_3.text = Team4.text;
        }
        /*===공백==*/
        if(Team_tear_3 <= 1)
        {
            player_5.text = Team5.text;
            player_6.text = Team6.text;
        }
        else
        {
            player_6.text = Team5.text;
            player_5.text = Team6.text;
        }
        /*===공백==*/
        if(Team_tear_4 <= 1)
        {
            player_7.text = Team7.text;
            player_8.text = Team8.text;
        }
        else
        {
            player_8.text = Team7.text;
            player_7.text = Team8.text;
        }
        /*===공백==*/
        if(Team_tear_5 <= 1)
        {
            player_9.text = Team9.text;
            player_10.text = Team10.text;
        }
        else
        {
            player_10.text = Team9.text;
            player_9.text = Team10.text;
        }
    }

    public void Team_2()
    {
        Confirm.SetActive(false);
    }
    
}
