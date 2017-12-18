using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFlyAnimation : MonoBehaviour {

    public float turnAngle;
    public PlaneControl planeC;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.localRotation = Quaternion.AngleAxis(-turnAngle * Input.GetAxis("Horizontal"), Vector3.forward);
	}

    void OnCollisionEnter(Collision collision)
    {
        

        planeC.isDie = true;
        
        Debug.Log("GameOver");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pointDoor")
        {
            planeC.bullets = 30;
            return;
        }
    }
}
