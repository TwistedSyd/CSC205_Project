using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{
    /* When button is clicked exit the game. */
    public void Quit()
    {
        PlayerPrefs.SetInt("Players", 2);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
