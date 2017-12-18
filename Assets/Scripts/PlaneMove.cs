using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {

    public float maxSpeed;
    public float normalspeed;
    public float turnspeed;
    public float turnAngle;
    public float speed;
    private Quaternion temp = Quaternion.identity;

	// Use this for initialization
	void Start () {
       // maxSpeed = normalspeed = speed = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightShift))
            speed = maxSpeed;
        else
            speed = normalspeed;
        
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, h * turnspeed, Space.World);
        //temp *= Quaternion.AngleAxis(turnspeed * h, Vector3.up); ;
        if (v != 0)
        {
            transform.rotation *= Quaternion.AngleAxis(-turnspeed * v, Vector3.right);
        }

        //transform.rotation *= Quaternion.AngleAxis(turnspeed * h, Vector3.up);
        //transform.rotation = Quaternion.AngleAxis(-turnAngle * v, Vector3.right);
    }

    private void OnGUI()
    {
        GUILayout.Label("Vector3.right : " + transform.right.ToString());
        GUILayout.Label("Vector3.up : " + transform.up.ToString());
    }
}
