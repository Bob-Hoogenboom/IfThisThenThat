using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


/// <summary>
/// Tutorial Source: https://www.youtube.com/watch?v=L4WfHT_58Dg 
/// Handles the string data recieved by the Arduino X the MPU-6050 Axis.
/// </summary>
public class GyroHandler : MonoBehaviour
{
    SerialPort com5 = new SerialPort("COM5", 115200);

    public string strRecieved;
    public string[] data = new string[4];
    public string[] dataRecieved = new string[4];
    public float qw, qx, qy, qz;


    // Start is called before the first frame update
    void Start()
    {
        com5.Open();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
