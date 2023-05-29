using UnityEngine;

public class CoolingTankSetup : MonoBehaviour
{
    public GameObject waterTank, rollerSupport, bearing1, bearing2, bearing3, bearing4;
    public GameObject roller1, roller2;
    // Start is called before the first frame update
    void OnEnable()
    {
        SubAssemblyManager.Long204Complete += EnableWaterTank;
        SubAssemblyManager.CoolingTank1Complete += EnableRollerSupport;
        SubAssemblyManager.CoolingTank1Complete += EnableRollers;
    }

    // Update is called once per frame
    void OnDisable()
    {
        SubAssemblyManager.Long204Complete -= EnableWaterTank;
        SubAssemblyManager.CoolingTank1Complete -= EnableRollerSupport;
        SubAssemblyManager.CoolingTank1Complete -= EnableRollers;
    }

    private void EnableWaterTank()
    {
        waterTank.SetActive(true);
    }

    private void EnableRollerSupport()
    {
        rollerSupport.SetActive(true);
        bearing1.SetActive(true);
        bearing2.SetActive(true);
        bearing3.SetActive(true);
        bearing4.SetActive(true);
    }

    private void EnableRollers()
    {
        roller1.SetActive(true);
        roller2.SetActive(true);
    }
}
