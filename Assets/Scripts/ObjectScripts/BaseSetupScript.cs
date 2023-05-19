using System;
using Unity.VisualScripting;
using UnityEngine;


public class BaseSetupScript : MonoBehaviour
{
    public GameObject bottombase, long120Support, long120Power;
    private void OnEnable()
    {
        PartCompletionScript.BothLong250Complete += SpawnBase;
        SubAssemblyManager.BaseStage1Complete += SpawnLong120;
    }

    private void OnDisable()
    {
        PartCompletionScript.BothLong250Complete -= SpawnBase;
        SubAssemblyManager.BaseStage1Complete -= SpawnLong120;
    }

    private void SpawnBase()
    {
        bottombase.SetActive(true);
    }

    private void SpawnLong120()
    {
        long120Support.SetActive(true);
        long120Power.SetActive(true);
    }

}
