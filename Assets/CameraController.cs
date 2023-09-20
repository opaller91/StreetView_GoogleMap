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
    //     streetview.forwardStreetView(streetview.latitude + 0.001000);
    //     // streetview.StreetView(StreetViewLoader.latitude,StreetViewLoader.longitude,streetview.pitch,streetview.heading);
    //     // Camera.main.transform.Position();
    // }

    // void moveBackward(){
    //     Camera.main.transform.Rotate(new Vector3(0, 90, 0));
    // }
}
