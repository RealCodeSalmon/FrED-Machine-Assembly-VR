using UnityEngine;

public class GhostSocketManager : MonoBehaviour
{
    private void OnEnable()
    {
        PartCompletionScript.BothLong250Complete += EnableBaseGhosts;
        SubAssemblyManager.Long120SupportComplete += EnableLongSupportGhost;
        SubAssemblyManager.Long120PowerComplete += EnableLongPowerGhost;
    }

    private void OnDisable()
    {
        PartCompletionScript.BothLong250Complete -= EnableBaseGhosts;
        SubAssemblyManager.Long120SupportComplete -= EnableLongSupportGhost;
        SubAssemblyManager.Long120PowerComplete -= EnableLongPowerGhost;
    }

    private void EnableBaseGhosts()
    {
        for (int i = 0; i < 3; i++) 
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    private void EnableLongSupportGhost()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }

    private void EnableLongPowerGhost()
    {
        gameObject.transform.GetChild(5).gameObject.SetActive(true);
    }
}
