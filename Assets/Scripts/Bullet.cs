using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 100;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
	}
}
