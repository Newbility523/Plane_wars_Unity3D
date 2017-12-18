using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public PlaneControl planeC;
    public float x = 500.0f;
    public float z = 500.0f;
    public float y = 300.0f;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            planeC.point++;
            GoNewPosition();
        }
    }

    void GoNewPosition()
    {
        transform.position = new Vector3(Random.Range(0, x), Random.Range(150, y), Random.Range(0, z));
    }
}
