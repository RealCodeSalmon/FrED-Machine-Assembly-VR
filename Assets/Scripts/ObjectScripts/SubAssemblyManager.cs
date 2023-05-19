using UnityEngine;

public class SubAssemblyManager : MonoBehaviour
{
    public int tasksToCompletion;
    private int completedTasks;
    public int subAssemblyID;

    public delegate void Long250_1CompleteAction();
    public static event Long250_1CompleteAction Long250_1SubAssemblyComplete;

    public delegate void Long250_2CompleteAction();
    public static event Long250_2CompleteAction Long250_2SubAssemblyComplete;

    public delegate void BaseStage1CompleteAction();
    public static event BaseStage1CompleteAction BaseStage1Complete;

    public delegate void Long120SupportCompleteAction();
    public static event Long120SupportCompleteAction Long120SupportComplete;

    public delegate void Long120PowerCompleteAction();
    public static event Long120PowerCompleteAction Long120PowerComplete;

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
        if(completedTasks >= tasksToCompletion)
        {
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
        }
    }
}
