using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Long120PowerConfig : MonoBehaviour
{
    void OnEnable()
    {
        SubAssemblyManager.Long120PowerComplete += ConfigCompletedLong120;
    }

    // Update is called once per frame
    void OnDisable()
    {
        SubAssemblyManager.Long120PowerComplete -= ConfigCompletedLong120;
    }

    private void ConfigCompletedLong120()
    {
        GetComponent<GhostPartSpawn>().enabled = true;
        GetComponent<XRGrabInteractable>().interactionLayers = InteractionLayerMask.GetMask("Long250Asm");
    }
}
