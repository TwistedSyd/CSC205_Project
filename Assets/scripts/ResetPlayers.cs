using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayers : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Players", 2);	
	}
}
