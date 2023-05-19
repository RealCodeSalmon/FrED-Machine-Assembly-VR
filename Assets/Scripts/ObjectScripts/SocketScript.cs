using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketScript : MonoBehaviour
{
    [SerializeField] private SubAssemblyManager subAssmManager;
    private XRSocketInteractor socket;

    private void Awake()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    private void OnEnable()
    {
        socket.selectEntered.AddListener(ObjectSnapped);
        socket.selectExited.AddListener(ObjectRemoved);
    }

    private void OnDisable()
    {
        socket.selectEntered.RemoveListener(ObjectSnapped);
        socket.selectExited.RemoveListener(ObjectRemoved);
    }

    private void ObjectSnapped(SelectEnterEventArgs arg0)
    {
        //Call completed task method from Assembly Manager
        subAssmManager.CompletedTask();

        //Get GameObject reference from the object inside socket
        IXRSelectInteractable snapObjInteractable = socket.GetOldestInteractableSelected();
        GameObject snapObjGameObject = snapObjInteractable.transform.gameObject;

        //Lock in Place
        snapObjGameObject.GetComponent<GhostPartSpawn>().enabled = false;
        snapObjGameObject.GetComponent<XRGrabInteractable>().interactionLayers = InteractionLayerMask.GetMask("Attached");

        //Disable Hovers 
        socket.showInteractableHoverMeshes = false;
    }

    //Should in theory never be called, we'll see hehe 
    private void ObjectRemoved(SelectExitEventArgs arg0)
    {
        subAssmManager.RemovedTask();
    }
}
