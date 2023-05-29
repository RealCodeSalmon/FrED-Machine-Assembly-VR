using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Long120SupportConfig : MonoBehaviour
{
    void OnEnable()
    {
        PartCompletionScript.BothLong120Complete += ConfigCompletedLong120;
    }

    // Update is called once per frame
    void OnDisable()
    {
        PartCompletionScript.BothLong120Complete -= ConfigCompletedLong120;
    }

    private void ConfigCompletedLong120()
    {
        GetComponent<GhostPartSpawn>().enabled = true;
        GetComponent<XRGrabInteractable>().interactionLayers = InteractionLayerMask.GetMask("Long120SAsm");
    }
}
