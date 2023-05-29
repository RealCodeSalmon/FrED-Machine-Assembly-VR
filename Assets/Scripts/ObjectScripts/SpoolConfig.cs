using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoolConfig : MonoBehaviour
{
    private int tasks = 0;
    private int complete = 2;
    public GameObject spoolBase;
    public void SpoolTaskCompletion()
    {
        tasks++;
        CheckCompletion();
    }

    private void CheckCompletion()
    {
        if(tasks >= complete)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            spoolBase.GetComponent<GhostPartSpawn>().enabled = true;
        }
    }
}
