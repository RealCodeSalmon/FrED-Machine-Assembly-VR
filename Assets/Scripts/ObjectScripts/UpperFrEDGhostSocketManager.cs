using System;
using UnityEngine;

public class UpperFrEDGhostSocketManager : MonoBehaviour
{
    private int cornerCompletion;
    private int childLen;

    private void Start()
    {
        childLen = gameObject.transform.childCount;
    }

    private void OnEnable()
    {
        SubAssemblyManager.BaseStage3Complete += EnableVerticalGhosts;
        SubAssemblyManager.Long204Complete += EnableCoolingTank1Ghosts;
        SubAssemblyManager.CoolingTank3Complete += EnableCoolingTank3Ghosts;
        PartCompletionScript.AllCoolingTanksComplete += EnableSpoolMech1Ghosts;
        SubAssemblyManager.SpoolMech1Complete += EnableSpoolMech2Ghosts;
        PartCompletionScript.AllSpoolsComplete += EnableCornerGhosts;
    }

    private void OnDisable()
    {
        SubAssemblyManager.BaseStage3Complete -= EnableVerticalGhosts;
        SubAssemblyManager.Long204Complete -= EnableCoolingTank1Ghosts;
        SubAssemblyManager.CoolingTank3Complete -= EnableCoolingTank3Ghosts;
        PartCompletionScript.AllCoolingTanksComplete -= EnableSpoolMech1Ghosts;
        SubAssemblyManager.SpoolMech1Complete -= EnableSpoolMech2Ghosts;
        PartCompletionScript.AllSpoolsComplete -= EnableCornerGhosts;
    }

    private void EnableVerticalGhosts()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    private void EnableCoolingTank1Ghosts()
    {
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

    private void EnableCoolingTank3Ghosts()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }

    private void EnableSpoolMech1Ghosts()
    {
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
        gameObject.transform.GetChild(5).gameObject.SetActive(true);
        gameObject.transform.GetChild(6).gameObject.SetActive(true);
        gameObject.transform.GetChild(7).gameObject.SetActive(true);
    }

    private void EnableSpoolMech2Ghosts()
    {
        gameObject.transform.GetChild(8).gameObject.SetActive(true);
    }

    private void EnableCornerGhosts()
    {
        gameObject.transform.GetChild(childLen - 2).gameObject.SetActive(true);
        gameObject.transform.GetChild(childLen - 3).gameObject.SetActive(true);
        gameObject.transform.GetChild(childLen - 4).gameObject.SetActive(true);
    }

    public void CornerTaskComplete()
    {
        cornerCompletion++;
        CheckCornerCompletion();
    }

    private void CheckCornerCompletion()
    { 
       if (cornerCompletion >= 2)
        {
            gameObject.transform.GetChild(childLen).gameObject.SetActive(true);
        }
    }
}
