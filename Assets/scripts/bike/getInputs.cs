﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getInputs : MonoBehaviour {
    
    private bike cycle;
    float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        cycle = GetComponentInParent<bike>();
    }

    // Update is called once per frame
    void Update() {

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Comma) || Input.GetKey(KeyCode.UpArrow)) && Time.time > startTime + 4.5f)
        {
            cycle.moveForward();
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            cycle.turnLeft();
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
        {
            cycle.turnRight();
        }

    }
}
