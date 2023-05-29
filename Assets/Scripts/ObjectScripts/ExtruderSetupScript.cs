using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtruderSetupScript : MonoBehaviour
{
    public GameObject extruder, long120P, long120S, corner1, corner2, sensor;

    private void OnEnable()
    {
        PartCompletionScript.AllSpoolsComplete += EnableExtruderParts;
    }

    private void OnDisable()
    {
        PartCompletionScript.AllSpoolsComplete -= EnableExtruderParts;
    }

    private void EnableExtruderParts()
    {
        extruder.SetActive(true);
        long120P.SetActive(true);
        long120S.SetActive(true);
        corner1.SetActive(true);    
        corner2.SetActive(true);    
        sensor.SetActive(true); 
    }
}
