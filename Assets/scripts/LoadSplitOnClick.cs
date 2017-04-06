using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSplitOnClick : MonoBehaviour {
    /* Load scene on click of button. */
    public void LoadSplit()
    {
        int players = PlayerPrefs.GetInt("Players");

        if(players == 2)
        {
            SceneManager.LoadScene(5);
        }
        else if(players == 3)
        {
            SceneManager.LoadScene(6);
        }
        else if(players == 4)
        {
            SceneManager.LoadScene(7);
        }
    }
}
