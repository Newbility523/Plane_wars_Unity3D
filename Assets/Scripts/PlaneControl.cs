using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour {

    public int bullets = 30;
    public bool isDie = false;
    public float speed;
    public int point = 0;

    public Transform gun;
    public GameObject bulletPrefab;
    public float fireInternal;
    private float currentTime;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if(currentTime > fireInternal && bullets > 0)
            {
                
                Instantiate(bulletPrefab, gun.position, gun.rotation);
                bullets--;
                currentTime = 0;
                //fire
            }
        }
        //if(Input.GetKey(KeyCode.R))
        //{
        //    bullets = 30;
        //}
	}
}
