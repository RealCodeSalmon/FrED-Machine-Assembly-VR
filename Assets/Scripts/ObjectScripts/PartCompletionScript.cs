using UnityEngine;
using TMPro;
using System.Collections;
using System;
using Unity.VisualScripting;

public class PartCompletionScript : MonoBehaviour
{
    private bool logAvailible = true;
    public TMP_Text textDebugField;

    [SerializeField] private int long250Completion =0;
    private bool long250_1Complete, long250_2Complete;

    [SerializeField] private int baseCompletion = 0;

    [SerializeField] private int long120Completion = 0;
    private bool longSupportComplete, longPowerComplete;

    [SerializeField] private int verticalBarsCompletion;

    [SerializeField] private int coolingTankCompletion = 0;

    [SerializeField] private int spoolingMechCompletion = 0;

    public delegate void StepsCompletedAction();    
    public static event StepsCompletedAction BothLong250Complete;

    public delegate void BothLong120CompletedAction();
    public static event BothLong120CompletedAction BothLong120Complete;

    public delegate void AllCoolingTanksCompletedAction();
    public static event AllCoolingTanksCompletedAction AllCoolingTanksComplete;

    public delegate void AllSpoolsCompletedAction();
    public static event AllSpoolsCompletedAction AllSpoolsComplete;

    private void OnEnable()
    {
        SubAssemblyManager.Long250_1SubAssemblyComplete += Long250_1Completed;
        SubAssemblyManager.Long250_2SubAssemblyComplete += Long250_2Completed;
        SubAssemblyManager.BaseStage1Complete += BaseStage1Completed;
        SubAssemblyManager.BaseStage2Complete += BaseStage2Completed;
        SubAssemblyManager.Long120SupportComplete += LongSupportCompleted;
        SubAssemblyManager.Long120PowerComplete += LongPowerCompleted;
        SubAssemblyManager.BaseStage3Complete += BaseStage3Completed;
        SubAssemblyManager.Long204Complete += VerticalBarsCompleted;
        SubAssemblyManager.CoolingTank1Complete += CoolingTank1Completed;
        SubAssemblyManager.CoolingTank2Complete += CoolingTank2Completed;
        SubAssemblyManager.CoolingTank3Complete += CoolingTank3Completed;
        SubAssemblyManager.SpoolMech1Complete += Spool1Completed;
        SubAssemblyManager.SpoolMech2Complete += Spool2Completed;
        SubAssemblyManager.SpoolMech3Complete += Spool3Completed;
        SubAssemblyManager.SpoolMech4Complete += Spool4Completed;
        SubAssemblyManager.SpoolMech5Complete += Spool5Completed;
    }

    private void OnDisable()
    {
        SubAssemblyManager.Long250_1SubAssemblyComplete -= Long250_1Completed;
        SubAssemblyManager.Long250_2SubAssemblyComplete -= Long250_2Completed;
        SubAssemblyManager.BaseStage1Complete -= BaseStage1Completed;
        SubAssemblyManager.BaseStage2Complete -= BaseStage2Completed;
        SubAssemblyManager.Long120SupportComplete -= LongSupportCompleted;
        SubAssemblyManager.Long120PowerComplete -= LongPowerCompleted;
        SubAssemblyManager.BaseStage3Complete -= BaseStage3Completed;
        SubAssemblyManager.Long204Complete -= VerticalBarsCompleted;
        SubAssemblyManager.CoolingTank1Complete -= CoolingTank1Completed;
        SubAssemblyManager.CoolingTank2Complete -= CoolingTank2Completed;
        SubAssemblyManager.CoolingTank3Complete -= CoolingTank3Completed;
        SubAssemblyManager.SpoolMech1Complete -= Spool1Completed;
        SubAssemblyManager.SpoolMech2Complete -= Spool2Completed;
        SubAssemblyManager.SpoolMech3Complete -= Spool3Completed;
        SubAssemblyManager.SpoolMech4Complete += Spool4Completed;
        SubAssemblyManager.SpoolMech5Complete += Spool5Completed;
    }

    private void Long250_1Completed()
    {
        long250_1Complete = true;
        long250Completion++;
        EnterDebugLog("Long250 completed [" + long250Completion + "/2]");
        CheckLong250Completion();
    }

    private void Long250_2Completed()
    {
        long250_2Complete = true;
        long250Completion++;
        EnterDebugLog("Long250 completed [" + long250Completion + "/2]");
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
        EnterDebugLog("Base Stage completed[" + baseCompletion + "/3]");
    }

    private void BaseStage2Completed()
    {
        baseCompletion++;
        EnterDebugLog("Base Stage completed[" + baseCompletion + "/3]");
    }

    private void LongSupportCompleted()
    {
        long120Completion++;
        longSupportComplete = true;
        EnterDebugLog("Long Support Complete [ " + long120Completion + "/2]");
        CheckLong120Completion();
    }
    private void LongPowerCompleted()
    {
        long120Completion++;
        longPowerComplete = true;
        EnterDebugLog("Long Power Complete [ " + long120Completion + "/2]");
        CheckLong120Completion();
    }

    private void CheckLong120Completion()
    {
        if (longPowerComplete && longSupportComplete)
        {
            if (BothLong120Complete != null)
                BothLong120Complete();
            EnterDebugLog("Both Long120 completed");
        }
    }

    private void BaseStage3Completed()
    {
        baseCompletion++;
        EnterDebugLog("Base Stage completed[" + baseCompletion + "/3]");
    }

    private void VerticalBarsCompleted()
    {
        verticalBarsCompletion++;
        EnterDebugLog("Long 204 completed Stage[" + verticalBarsCompletion + "/1]");
    }

    private void CoolingTank1Completed()
    {
        coolingTankCompletion++;
        EnterDebugLog("CoolingTank Complete [" + coolingTankCompletion + "/3]");
        CheckCoolingTankCompletion();
    }

    private void CoolingTank2Completed()
    {
        coolingTankCompletion++;
        EnterDebugLog("CoolingTank Complete [" + coolingTankCompletion + "/3]");
        CheckCoolingTankCompletion();
    }

    private void CoolingTank3Completed()
    {
        coolingTankCompletion++;
        EnterDebugLog("CoolingTan Complete [" + coolingTankCompletion + "/3]");
        CheckCoolingTankCompletion();
    }

    private void CheckCoolingTankCompletion()
    {
        if (coolingTankCompletion >= 3)
        {
            if (AllCoolingTanksComplete != null)
                AllCoolingTanksComplete();
        }
    }

    private void Spool1Completed()
    {
        spoolingMechCompletion++;
        EnterDebugLog("SpoolMech Complete [" + spoolingMechCompletion + "/5]");
        CheckSpoolCompletion();
    }

    private void Spool2Completed()
    {
        spoolingMechCompletion++;
        EnterDebugLog("SpoolMech Complete [" + spoolingMechCompletion + "/5]");
        CheckSpoolCompletion();
    }

    private void Spool3Completed()
    {
        spoolingMechCompletion++;
        EnterDebugLog("SpoolMech Complete [" + spoolingMechCompletion + "/5]");
        CheckSpoolCompletion();
    }

    private void Spool4Completed()
    {
        spoolingMechCompletion++;
        EnterDebugLog("SpoolMech Complete [" + spoolingMechCompletion + "/5]");
        CheckSpoolCompletion();
    }

    private void Spool5Completed()
    {
        spoolingMechCompletion++;
        EnterDebugLog("SpoolMech Complete [" + spoolingMechCompletion + "/5]");
        CheckSpoolCompletion();
    }

    private void CheckSpoolCompletion()
    {
        EnterDebugLog("All SpoolMech Complete");
        if (spoolingMechCompletion >= 5)
        {
            if(AllSpoolsComplete != null)
                AllSpoolsComplete();
        }
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
