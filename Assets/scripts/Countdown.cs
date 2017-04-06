using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        StartCoroutine(countDown());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator countDown()
    {
        text.text = "3";
        yield return new WaitForSeconds(1.5f);
        text.text = "2";
        yield return new WaitForSeconds(1.5f);
        text.text = "1";
        yield return new WaitForSeconds(1.5f);
        text.text = "G O !";
        yield return new WaitForSeconds(1);
        text.text = "";
    }
}
