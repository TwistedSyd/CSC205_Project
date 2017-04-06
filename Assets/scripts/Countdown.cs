using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public AudioSource music;
    public AudioSource bing;
    public AudioSource go;
    public AudioSource drive1;
    public AudioSource drive2;

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
        Instantiate(bing, transform.position, transform.rotation);
        Instantiate(music, transform.position, transform.rotation);
        text.text = "3";
        yield return new WaitForSeconds(1.5f);
        Instantiate(bing, transform.position, transform.rotation);
        text.text = "2";
        yield return new WaitForSeconds(1.5f);
        Instantiate(bing, transform.position, transform.rotation);
        text.text = "1";
        yield return new WaitForSeconds(1.5f);
        Instantiate(go, transform.position, transform.rotation);
        Instantiate(drive1, transform.position, transform.rotation);
        Instantiate(drive2, transform.position, transform.rotation);
        text.text = "G O !";
        yield return new WaitForSeconds(1);
        text.text = "";
    }
}
