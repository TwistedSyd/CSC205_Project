using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bike : MonoBehaviour {

    public float movementSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void moveForward()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    public void turnLeft()
    {
        //TODO
    }

    public void turnRight()
    {
        //TODO
    }
}
