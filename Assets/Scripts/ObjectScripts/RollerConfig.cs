using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerConfig : MonoBehaviour
{
    private GhostPartSpawn ghostScript;

    // Start is called before the first frame update
    private void Awake()
    {
        ghostScript = GetComponent<GhostPartSpawn>();
    }
    // Update is called once per frame
    private void OnEnable()
    {
        SubAssemblyManager.CoolingTank2Complete += RollerCnfg;
    }

    private void OnDisable()
    {
        SubAssemblyManager.CoolingTank2Complete -= RollerCnfg;
    }

    private void RollerCnfg()
    {
        ghostScript.enabled = true;
    }
}
