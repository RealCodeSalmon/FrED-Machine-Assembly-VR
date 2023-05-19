using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GhostPartSpawn : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    public GameObject[] Ghosts;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        grabInteractable.selectEntered.AddListener(SpawnGhost);
        grabInteractable.selectExited.AddListener(RemoveGhost);
    }

    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(SpawnGhost);
        grabInteractable.selectExited.RemoveListener(RemoveGhost);
        for (int i = 0; i < Ghosts.Length; i++)
        {
            Ghosts[i].GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void RemoveGhost(SelectExitEventArgs arg0)
    {
        for(int i =0; i < Ghosts.Length; i++)
        {
            Ghosts[i].GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void SpawnGhost(SelectEnterEventArgs arg0)
    {
        for (int i = 0; i < Ghosts.Length; i++)
        {
            Ghosts[i].GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
