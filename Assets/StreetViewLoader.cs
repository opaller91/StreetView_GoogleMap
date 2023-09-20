using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetViewLoader : MonoBehaviour
{
    public Material material;
    public double heading = 0.0;
    public double pitch = 0.0;
    
    private int width = 2048;
    private int height = 2048;

    public double longitude = 128.507333;
    public double latitude = 35.843904;
    private Texture2D frontTex, leftTex, rightTex, backTex, upTex, downTex;

    // Use this for initialization
    void Start()
    {

        StreetView(latitude,longitude,pitch,heading);
        
    }

    public void StreetView(double latitude,double longitude,double pitch,double heading)
    {
        StartCoroutine(GetStreetViewImage(latitude, longitude, 0, pitch));
        StartCoroutine(GetStreetViewImage(latitude, longitude, 90, pitch));
        StartCoroutine(GetStreetViewImage(latitude, longitude, 180, pitch));
        StartCoroutine(GetStreetViewImage(latitude, longitude, 270, pitch));
        StartCoroutine(GetStreetViewImage(latitude, longitude, heading, 90));
        StartCoroutine(GetStreetViewImage(latitude, longitude, heading, -90));
        StartCoroutine(WaitTime());
    }

    private void SetSkybox(Material material)
    {
        RenderSettings.skybox = material;
        DynamicGI.UpdateEnvironment();
    }

    private Material setMaterial()
    {
        material.SetTexture("_FrontTex", frontTex);
        material.SetTexture("_BackTex", backTex);
        material.SetTexture("_LeftTex", leftTex);
        material.SetTexture("_RightTex", rightTex);
        material.SetTexture("_UpTex", upTex);
        material.SetTexture("_DownTex", downTex);
        return material;
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1f);
        Material material = setMaterial();
        SetSkybox(material);
    }

    private IEnumerator GetStreetViewImage(double latitude, double longitude, double heading, double pitch)
    {
        string url = "http://maps.googleapis.com/maps/api/streetview?" + "size=" + width + "x" + height + "&location=" + latitude + "," + longitude + "&fov=80" + "&heading=" + heading + "&pitch=" + pitch + "&key=AIzaSyAe1pyvALYCjngz7x1c3nfMlcZ3hkl63U0";

        WWW www = new WWW(url);
        yield return www;
        www.texture.wrapMode = TextureWrapMode.Clamp;
        if ((int)heading == 0)
        {
            if ((int)pitch == 0)
            {
                frontTex = www.texture;
            }
            else if ((int)pitch == 90)
            {
                upTex = www.texture;
            }
            else if ((int)pitch == -90)
            {
                downTex = www.texture;
            }
        }
        else if ((int)heading == 90)
        {
            leftTex = www.texture;
        }
        else if ((int)heading == 180)
        {
            backTex = www.texture;
        }
        else if ((int)heading == 270)
        {
            rightTex = www.texture;
        }
        Debug.Log(www.texture);
    }

    // public void forwardStreetView(double newLatitude){
    //     this.latitude = newLatitude;
    //     StreetView(latitude,longitude,pitch,heading);
    // }
}
