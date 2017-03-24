using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNeonGrid : MonoBehaviour {

    public int gridDimension;
    public Transform line; //Stores neon line prefab


	void Start () {

        int max = gridDimension / 2 + 1;
        for (int i = -gridDimension / 2; i < max; i++) //Loop through all lines to be generated
        {
            for(int j = 0; j < 2; j++)  //Both directions
            {
                if(j == 0)
                {
                    Instantiate(line, new Vector3(i, 0.01f, 0), Quaternion.Euler(0,0,0), null); //Vertical lines
                }
                else
                {
                    Instantiate(line, new Vector3(0, 0.01f, i), Quaternion.Euler(0, 90, 0), null); //Horizontal lines
                }
            }
        }

	}
	
}
