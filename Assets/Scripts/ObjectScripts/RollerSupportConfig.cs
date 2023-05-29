using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RollerSupportConfig : MonoBehaviour
{
    public GameObject rollerghost1, rollerghost2;
    // Start is called before the first frame update

    private void OnEnable()
    {
        SubAssemblyManager.CoolingTank2Complete += RollerSuppConfig;
    }

    private void OnDisable()
    {
        SubAssemblyManager.CoolingTank2Complete -= RollerSuppConfig;
    }

    void RollerSuppConfig()
    {
        rollerghost1.SetActive(true);
        rollerghost2.SetActive(true);
    }
}
