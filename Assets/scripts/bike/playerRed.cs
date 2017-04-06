using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRed : MonoBehaviour
{

    private bike cycle;
    float startTime;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        cycle = GetComponentInParent<bike>();
    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKey(KeyCode.W)) && Time.time > startTime + 4.5f)
        {
            cycle.moveForward();
        }

        if (Input.GetKey(KeyCode.A))
        {
            cycle.turnLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            cycle.turnRight();
        }

    }
}
