using UnityEngine;


public class BaseSetupScript : MonoBehaviour
{
    public GameObject bottombase, long120Support, long120Power, corner1, corner2, topbase;
    private void OnEnable()
    {
        PartCompletionScript.BothLong250Complete += SpawnBase;
        SubAssemblyManager.BaseStage1Complete += SpawnLong120;
        SubAssemblyManager.BaseStage2Complete += SpawnCorners;
    }

    private void OnDisable()
    {
        PartCompletionScript.BothLong250Complete -= SpawnBase;
        SubAssemblyManager.BaseStage1Complete -= SpawnLong120;
        SubAssemblyManager.BaseStage2Complete += SpawnCorners;
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

    private void SpawnCorners()
    {
        corner1.SetActive(true);
        corner2.SetActive(true);
        topbase.SetActive(true);
    }
}
