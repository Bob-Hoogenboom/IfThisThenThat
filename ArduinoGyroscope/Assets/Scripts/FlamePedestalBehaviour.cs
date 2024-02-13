using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamePedestalBehaviour : MonoBehaviour
{
    public Material defaultMaterial;
    public GameObject flame;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.GetComponent<FlameTrigger>()) return;

        var flameTrigger = other.gameObject.GetComponent<FlameTrigger>();
        var flameTriggerMat = flameTrigger.flameMaterial;
        flame.GetComponent<Renderer>().material = flameTriggerMat;
        
        if(flameTrigger.led == 1)
        {
            //blue LED
        }
        else if (flameTrigger.led == 2)
        {
            //Red LED
        }

    }

    private void OnTriggerExit(Collider other)
    {
        flame.GetComponent<Renderer>().material = defaultMaterial;
        //White LED
    }
}
