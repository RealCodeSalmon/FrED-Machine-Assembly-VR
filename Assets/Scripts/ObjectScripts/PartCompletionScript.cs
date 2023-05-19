using UnityEngine;
using TMPro;
using System.Collections;

public class PartCompletionScript : MonoBehaviour
{
    private bool logAvailible = true;
    public TMP_Text textDebugField;

    [SerializeField] private int longTaskCompletion =0;
    private bool long250_1Complete, long250_2Complete;

    [SerializeField] private int baseCompletion = 0;
    private bool baseStage1Complete, baseStage2Complete;
    private bool longSupportComplete;
    private bool longPowerComplete;

    public delegate void StepsCompletedAction();    
    public static event StepsCompletedAction BothLong250Complete;

    private void OnEnable()
    {
        SubAssemblyManager.Long250_1SubAssemblyComplete += Long250_1Completed;
        SubAssemblyManager.Long250_2SubAssemblyComplete += Long250_2Completed;
        SubAssemblyManager.BaseStage1Complete += BaseStage1Completed;
        SubAssemblyManager.Long120SupportComplete += LongSupportCompleted;
        SubAssemblyManager.Long120PowerComplete += LongPowerCompleted;
    }

    private void OnDisable()
    {
        SubAssemblyManager.Long250_1SubAssemblyComplete -= Long250_1Completed;
        SubAssemblyManager.Long250_2SubAssemblyComplete -= Long250_2Completed;
        SubAssemblyManager.BaseStage1Complete -= BaseStage1Completed;
        SubAssemblyManager.Long120SupportComplete -= LongSupportCompleted;
        SubAssemblyManager.Long120PowerComplete -= LongPowerCompleted;
    }

    private void Long250_1Completed()
    {
        long250_1Complete = true;
        longTaskCompletion++;
        EnterDebugLog("Long250 completed [" + longTaskCompletion + "/2]");
        CheckLong250Completion();
    }

    private void Long250_2Completed()
    {
        long250_2Complete = true;
        longTaskCompletion++;
        EnterDebugLog("Long250 completed [" + longTaskCompletion + "/2]");
        CheckLong250Completion();
    }

    private void CheckLong250Completion()
    {
        if (long250_1Complete && long250_2Complete)
        {
            if (BothLong250Complete != null)
                BothLong250Complete();
            EnterDebugLog("Both Long250 completed");
        }
    }

    private void BaseStage1Completed()
    {
        baseCompletion++;
        baseStage1Complete = true;
        EnterDebugLog("Base Stage completed[" + baseCompletion + "]");
    }

    private void BaseStage2Completed()
    {
        baseCompletion++;
        baseStage2Complete = true;
        EnterDebugLog("Base Stage completed[" + baseCompletion + "]");
    }

    private void LongSupportCompleted()
    {
        longSupportComplete = true;
        EnterDebugLog("LongSupportComplete");
    }

    private void LongPowerCompleted()
    {
        longPowerComplete = true;
        EnterDebugLog("LongPowerComplete");
    }

    public void EnterDebugLog(string text)
    {
        textDebugField.text = text;
        StartCoroutine(DisplayDebugText());
    }

    private IEnumerator DisplayDebugText()
    {
        yield return new WaitUntil(() => logAvailible == true); 
        logAvailible = false;
        textDebugField.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        textDebugField.gameObject.SetActive(false);
        logAvailible = true;
    }
}
