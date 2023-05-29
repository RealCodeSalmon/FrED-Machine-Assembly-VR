using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoolingMechSetup : MonoBehaviour
{
    public GameObject axleSupp1, axleSupp2, axleSuppTall1, axleSuppTall2;
    public GameObject rowlock1, rowlock2, rowlock3, rowlock4;
    public GameObject nema17, couple, nema17Base;
    public GameObject linealGuide, railFitting, rail;
    public GameObject screw, axle1, gear1;
    public GameObject spoolbase, spoolleft, spoolright, axle2, gear2;

    private void OnEnable()
    {
        PartCompletionScript.AllCoolingTanksComplete += EnableAxleSupports;
        SubAssemblyManager.SpoolMech1Complete += EnableNemaParts;
        SubAssemblyManager.SpoolMech2Complete += EnableRailSystem;
        SubAssemblyManager.SpoolMech3Complete += EnableScrewAxle;
        SubAssemblyManager.SpoolMech4Complete += EnableSpoolAxle;
    }

    private void OnDisable()
    {
        PartCompletionScript.AllCoolingTanksComplete -= EnableAxleSupports;
        SubAssemblyManager.SpoolMech1Complete -= EnableNemaParts;
        SubAssemblyManager.SpoolMech2Complete -= EnableRailSystem;
        SubAssemblyManager.SpoolMech3Complete -= EnableScrewAxle;
        SubAssemblyManager.SpoolMech4Complete -= EnableSpoolAxle;
    }

    private void EnableAxleSupports()
    {
        axleSupp1.SetActive(true); axleSupp2.SetActive(true);
        axleSuppTall1.SetActive(true); axleSuppTall2.SetActive(true);
        rowlock1.SetActive(true); rowlock2.SetActive(true);rowlock3.SetActive(true);rowlock4.SetActive(true);
    }

    private void EnableNemaParts()
    {
        nema17.SetActive(true);
        nema17Base.SetActive(true); 
        couple.SetActive(true);
    }

    private void EnableRailSystem()
    {
        linealGuide.SetActive(true);
        railFitting.SetActive(true);
        rail.SetActive(true);   
    }

    private void EnableScrewAxle()
    {
        screw.SetActive(true);
        axle1.SetActive(true);
        gear1.SetActive(true);
    }

    private void EnableSpoolAxle()
    {
        spoolbase.SetActive(true);
        spoolleft.SetActive(true);
        spoolright.SetActive(true); 
        axle2.SetActive(true);
        gear2.SetActive(true);
    }
}
