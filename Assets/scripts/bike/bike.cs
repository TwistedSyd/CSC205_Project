using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bike : MonoBehaviour {

    public float movementSpeed;
    public float turnSpeed;

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
        transform.Rotate(new Vector3(0, -0.8f * turnSpeed, 0));
    }

    public void turnRight()
    {
        transform.Rotate(new Vector3(0, 0.8f * turnSpeed, 0));
    }
}
