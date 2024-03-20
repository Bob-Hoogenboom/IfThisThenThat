using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class ArduinoFeedback : MonoBehaviour
{
    public string[] ports = SerialPort.GetPortNames();
    public SerialPort arduinoPort;

    void Start()
    {
        //search for a port with active input from an Arduino
        foreach (string port in ports)
        {
            if (port.Contains("COM")) //string search is inefficient
            {
                Debug.Log(port);
                arduinoPort = new SerialPort(port, 115200);
                arduinoPort.Open();
            }
            else
            {
                Debug.LogWarning("No Arduino Found");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Red")
        {
            if (!arduinoPort.IsOpen)
            {
                arduinoPort.Open();
            }
            RedLED();
        }

        if (collision.gameObject.tag == "Blue")
        {
            if (!arduinoPort.IsOpen)
            {
                arduinoPort.Open();
            }
            BlueLED();
        }

        if (collision.gameObject.tag == "Buzzer")
        {
            if (!arduinoPort.IsOpen)
            {
                arduinoPort.Open();
            }
            Buzzer();
        }
    }



    public void RedLED()
    {
        arduinoPort.Write("Red");
    }

    public void BlueLED()
    {
        arduinoPort.Write("Blue");
    }

    public void Buzzer()
    {
        arduinoPort.Write("Buzzer");
    }
}
