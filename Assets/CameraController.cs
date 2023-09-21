using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    //Rotate
    // public float camSpeed = -0.5f;
    // private float x;
    // private float y;
    // private Vector3 rotateValue;

    //90 Degree
    public Button rightBt;
    public Button leftBt;
    public Button forwardBt;
    public Button backwardBt;
    // private float targetAngle = 0;
    // public float yy;
    public StreetViewLoader streetview;
    public float meters = 50;
    public double new_lats;
    public double new_longs;

    // Start is called before the first frame update
    void Start()
    {
        // yy = Camera.main.transform.rotation.y;
        // rightBt.onClick.AddListener(turnRight);
        // leftBt.onClick.AddListener(turnLeft);
    }

    // Update is called once per frame
    void Update()
    {
        // x = Input.GetAxis(Camera.main);
        // y = Input.GetAxis(Camera.main);
        // Debug.Log(x + ":" + y);
        // rotateValue = new Vector3(y, x * -1, 0);
        // transform.eulerAngles = transform.eulerAngles - rotateValue;
        // transform.eulerAngles +=  rotateValue * camSpeed;

        // yy = Camera.main.transform.rotation.y;
        rightBt.onClick.AddListener(turnRight);
        leftBt.onClick.AddListener(turnLeft);
        // forwardBt.onClick.AddListener(moveForward);
        
    }

    void turnRight(){
        Camera.main.transform.Rotate(new Vector3(0, -90, 0));
    }

    void turnLeft(){
        Camera.main.transform.Rotate(new Vector3(0, 90, 0));
    }

    // void moveForward(){
    //     // float latf = (float)streetview.latitude;
    //     // float longf = (float)streetview.longitude;

    //     // 111.32km = 111320.0m
    //     // float coef = meters /(float)111320.0;
    //     // float new_latf = latf + coef;
    //     // new_latf = Mathf.Round(new_latf * 100.0f) * 0.000001f;
    //     // decimal new_latd = new decimal(new_latf);
    //     // double new_lat = (double) new_latd;
    //     // this.new_lats = new_lat;
        
        
    //     // pi / 180 ~= 0.01745
    //     // float cos_lat =  Mathf.Cos(latf  * (float)0.01745);
    //     // float new_longf = longf + coef / cos_lat;
    //     // new_longf = Mathf.Round(new_longf * 100.0f) * 0.000001f;
    //     // decimal new_longd = new decimal(new_longf);
    //     // double new_long = (double) new_longf;
    //     // this.new_longs = new_long;
        
    //     //---------------------------------
    //     // double new_lat = streetview.latitude - 0.000085;
    //     // double new_long = streetview.longitude + 0.000001;
    //     // streetview.forwardStreetView(new_lat,new_long);
    //     // Camera.main.transform.Position();
    // }

    // void moveBackward(){
    //     Camera.main.transform.Rotate(new Vector3(0, 90, 0));
    // }
}
