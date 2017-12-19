using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {

    public float maxSpeed;
    public float normalSpeed;
    public float yawSpeed;
    public float pitchAngle;
    public float pitchSpeed;
    public float currentSpeed;
    private Quaternion temp = Quaternion.identity;
    private float totalAngle;

	// Use this for initialization
	void Start () {
       // maxSpeed = normalspeed = speed = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        //SpeedUp
        if (Input.GetKey(KeyCode.RightShift))
            currentSpeed = maxSpeed;
        else
            currentSpeed = normalSpeed;
        
        transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        totalAngle += h * yawSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(-v * pitchAngle, totalAngle, 0);
    }

    private void OnGUI()
    {
        // GUILayout.Label("Vector3.right : " + transform.right.ToString());
        // GUILayout.Label("Vector3.up : " + transform.up.ToString());
    }
}
