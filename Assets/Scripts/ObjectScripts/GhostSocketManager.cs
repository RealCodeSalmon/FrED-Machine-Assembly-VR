using UnityEngine;

public class GhostSocketManager : MonoBehaviour
{
    private void OnEnable()
    {
        PartCompletionScript.BothLong250Complete += EnableBaseGhosts;
        PartCompletionScript.BothLong120Complete += EnableLong120Ghosts;
        SubAssemblyManager.BaseStage2Complete += EnableCornerGhosts;

    }

    private void OnDisable()
    {
        PartCompletionScript.BothLong250Complete -= EnableBaseGhosts;
        PartCompletionScript.BothLong120Complete += EnableLong120Ghosts;
        SubAssemblyManager.BaseStage2Complete -= EnableCornerGhosts;

    }

    private void EnableBaseGhosts()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

    private void EnableLong120Ghosts()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
        gameObject.transform.GetChild(5).gameObject.SetActive(true);
        gameObject.transform.GetChild(6).gameObject.SetActive(true);
    }

    private void EnableCornerGhosts()
    {
        gameObject.transform.GetChild(7).gameObject.SetActive(true);
        gameObject.transform.GetChild(8).gameObject.SetActive(true);
        gameObject.transform.GetChild(9).gameObject.SetActive(true);
    }
}
