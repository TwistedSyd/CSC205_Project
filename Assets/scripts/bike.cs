using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bike : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.forward = new Vector3(1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void moveForward()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
