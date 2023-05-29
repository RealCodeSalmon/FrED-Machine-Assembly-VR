using UnityEngine;

public class VerticalBarsSetup : MonoBehaviour
{
    public GameObject long204_1, long204_2;
    // Start is called before the first frame update
    void OnEnable()
    {
        SubAssemblyManager.BaseStage3Complete += EnableLong204;
    }

    private void OnDisable()
    {
        SubAssemblyManager.BaseStage3Complete -= EnableLong204;
    }


    void EnableLong204()
    {
        long204_1.SetActive(true);
        long204_2.SetActive(true);
    }
}
