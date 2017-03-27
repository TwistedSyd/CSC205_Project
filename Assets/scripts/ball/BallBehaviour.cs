using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public float forceApplied = 50;

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Player")
        {
            Vector3 direction = col.transform.forward;
            direction.y = 0;

            gameObject.GetComponent<Rigidbody>().AddForce(direction);
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
