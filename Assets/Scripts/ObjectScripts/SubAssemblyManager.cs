using UnityEngine;

public class SubAssemblyManager : MonoBehaviour
{
    public int tasksToCompletion;
    private int completedTasks;
    public int subAssemblyID;
    private bool eventCalled = false;

    public delegate void Long250_1CompleteAction();
    public static event Long250_1CompleteAction Long250_1SubAssemblyComplete, Long250_2SubAssemblyComplete;

    public delegate void BaseStage1CompleteAction();
    public static event BaseStage1CompleteAction BaseStage1Complete, BaseStage2Complete, BaseStage3Complete;


    public delegate void Long120SupportCompleteAction();
    public static event Long120SupportCompleteAction Long120SupportComplete, Long120PowerComplete;


    public delegate void Long204CompleteAction();
    public static event Long204CompleteAction Long204Complete;

    public delegate void CoolingTankCompleteAction();
    public static event CoolingTankCompleteAction CoolingTank1Complete, CoolingTank2Complete, CoolingTank3Complete;

    public delegate void SpoolingMechCompleteAction();
    public static event SpoolingMechCompleteAction SpoolMech1Complete, SpoolMech2Complete, SpoolMech3Complete;
    public static event SpoolingMechCompleteAction SpoolMech4Complete, SpoolMech5Complete;

    public delegate void ExtruderCompleteAction();
    public static event ExtruderCompleteAction ExtruderComplete;

    public void CompletedTask()
    {
        completedTasks++;
        CheckCompletion();
    }

    public void RemovedTask()
    {
        completedTasks--;
    }

    private void CheckCompletion()
    {
        if(completedTasks >= tasksToCompletion && !eventCalled)
        {
            eventCalled = true;
            InvokeEvent(subAssemblyID);
        }
    }

    private void InvokeEvent(int subAssembly)
    {
        switch (subAssembly)
        {
            case 1:
                if (Long250_1SubAssemblyComplete != null)
                    Long250_1SubAssemblyComplete();
                break;
            case 2:
                if (Long250_2SubAssemblyComplete != null)
                    Long250_2SubAssemblyComplete();
                break;
            case 3:
                if (BaseStage1Complete != null)
                    BaseStage1Complete(); 
                break;
            case 4:
                if (Long120SupportComplete != null)
                    Long120SupportComplete();
                break; 
            case 5:
                if (Long120PowerComplete != null)
                    Long120PowerComplete();
                break;
            case 6:
                if (BaseStage2Complete != null)
                    BaseStage2Complete();
                break;
            case 7:
                if (BaseStage3Complete != null)
                    BaseStage3Complete();
                break;
            case 8:
                if (Long204Complete != null)
                    Long204Complete();
                break;
            case 9:
                if (CoolingTank1Complete != null)
                    CoolingTank1Complete();
                break;
            case 10:
                if (CoolingTank2Complete != null)
                    CoolingTank2Complete();
                break;
            case 11:
                if (CoolingTank3Complete != null)
                    CoolingTank3Complete();
                break;
            case 12:
                if(SpoolMech1Complete!= null)
                    SpoolMech1Complete();
                break;
            case 13:
                if (SpoolMech2Complete != null)
                    SpoolMech2Complete();
                break;
            case 14:
                if (SpoolMech3Complete != null)
                    SpoolMech3Complete();
                break;
            case 15:
                if (SpoolMech4Complete != null)
                    SpoolMech4Complete();
                break;
            case 16:
                if (SpoolMech5Complete != null)
                    SpoolMech5Complete();
                break;
            case 17:
                if (ExtruderComplete != null)
                    ExtruderComplete();
                break;
        }
    }
}
