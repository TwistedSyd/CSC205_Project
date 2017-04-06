using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour {

    int players = 2;
    Text text;

	public void numPlayers(int num)
    {
        text = GameObject.Find("Players").GetComponent<Text>();
        players = PlayerPrefs.GetInt("Players", players);
        if(num == 0)
        {
           players--;
           if(players < 2)
            {
                players = 2;
            }
        }
        if(num == 1)
        {
           players++;
            if(players > 4)
            {
                players = 4;
            }
        }
        PlayerPrefs.SetInt("Players", players);
        text.text = "" + players;
    }
}
