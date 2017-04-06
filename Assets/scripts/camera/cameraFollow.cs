using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour
{

    public GameObject player;
    private Quaternion lastRotation;

    void Start()
    {

        //player = GameObject.Find("redBike");
        lastRotation = player.transform.rotation;

    }


    void LateUpdate()
    {

        transform.position = player.transform.position;
        transform.position -= player.transform.forward;
        transform.position += 2 * player.transform.up;

        if (player.transform.rotation != lastRotation)
        {
            var forwardA = lastRotation * Vector3.forward; //Vector for rotation
            var forwardB = player.transform.rotation * Vector3.forward;

            var angleA = Mathf.Atan2(forwardA.x, forwardA.z) * Mathf.Rad2Deg; //Angle for vector
            var angleB = Mathf.Atan2(forwardB.x, forwardB.z) * Mathf.Rad2Deg;

            var angleDiff = Mathf.DeltaAngle(angleA, angleB); //Signed angle difference

            transform.RotateAround(transform.position, player.transform.up, angleDiff);
            lastRotation = player.transform.rotation;
        }
    }
}