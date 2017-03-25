using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getInputs : MonoBehaviour {
    
    private bike cycle;

	// Use this for initialization
	void Start () {

        cycle = GetComponentInParent<bike>();

	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Comma) || Input.GetKey(KeyCode.UpArrow))
        {
            cycle.moveForward();
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            cycle.moveForward();
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
        {
            cycle.moveForward();
        }

    }
}
