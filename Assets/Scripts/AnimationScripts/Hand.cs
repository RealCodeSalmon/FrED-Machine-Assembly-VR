using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Hand : MonoBehaviour
{
    public SkinnedMeshRenderer mRenderer;
    Animator animator;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurrent;
    private float triggerCurrent;
    public float speed = 10f;
    private string gripParam = "Grip";
    private string triggerParam = "Trigger";
    private bool intersects;

    public bool collides { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        if(gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(gripParam, gripCurrent);
        }

        if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(triggerParam, triggerCurrent);
        }

    }

    public void OpenHand()
    {
        mRenderer.enabled = true;
    } 

    public void CloseHand()
    {
        DelayedMeshToggle();
    }

    private async void DelayedMeshToggle()
    {
        await Task.Delay(300);
        mRenderer.enabled = false;
    }
}
