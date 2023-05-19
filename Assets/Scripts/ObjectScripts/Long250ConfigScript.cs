using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Long250ConfigScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        PartCompletionScript.BothLong250Complete += ConfigCompletedLong250;
    }

    // Update is called once per frame
    void OnDisable()
    {
        PartCompletionScript.BothLong250Complete -= ConfigCompletedLong250;
    }

    private void ConfigCompletedLong250()
    {
        GetComponent<GhostPartSpawn>().enabled = true;
        GetComponent<XRGrabInteractable>().interactionLayers = InteractionLayerMask.GetMask("Long250Asm");
    }
}
