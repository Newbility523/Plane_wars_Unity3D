using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControal : MonoBehaviour {

    public Text height;
    public Text bullets;
    public Text point;
    public Text speed;
    public Text gameOver;
    public PlaneControl plane;
    public PlaneMove planeMove;
    public Button regame;
    public Button exit;


	// Use this for initialization
	void Start () {
        gameOver.gameObject.SetActive(false);
        regame.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        DisplayHeight();
        DisplayBullets();
        DisplayPoint();
        DisplaySpeed();
        if(plane.isDie == true)
        {
            gameOver.gameObject.SetActive(true);
            regame.gameObject.SetActive(true);
            exit.gameObject.SetActive(true);

            plane.enabled = false;
            planeMove.enabled = false;
        }
	}

    void DisplayHeight()
    {
        float temp = plane.transform.position.y;
        if (temp < 150) {
            height.color = Color.red;
            height.text = "高度(过低)：" + (int)temp;
            return;
        }
        height.color = Color.black;
        height.text = "高度(正常)：" + (int)temp;
    }

    void DisplayBullets()
    {
        int temp = plane.bullets;
        if (temp <= 0)
        {
            bullets.color = Color.red;
            bullets.text = "子弹(用尽)：" + temp;
            return;
        }
        if (temp <= 10)
        {
            bullets.color = Color.red;
            bullets.text = "子弹(低)：" + temp;
            return;
        }
        bullets.color = Color.black;
        bullets.text = "子弹：" + temp;
    }

    void DisplayPoint()
    {
        int temp = plane.point;
        point.color = Color.black;
        point.text = "分数：" + temp;
    }

    void DisplaySpeed()
    {
        float temp = planeMove.currentSpeed;
        if (temp <=100 )
        {
            speed.color = Color.black;
            speed.text = "速度：" + (int)temp;
            return;
        }
        speed.color = Color.red;
        speed.text = "速度(急速)：" + (int)temp;
    }

    public void Regame()
    {
        SceneManager.LoadScene("demo");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
