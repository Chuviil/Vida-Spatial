using System.Collections;
using SpatialSys.UnitySDK;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public void CompleteQuestAfter30Seconds()
    {
        StartCoroutine(WaitAndCompleteEvent());
    }
    
    IEnumerator WaitAndCompleteEvent()
    {
        yield return new WaitForSeconds(30);

        IQuest questId = SpatialBridge.questService.currentQuest;
        IQuestTask task = questId.GetTaskByID(2);
        task.Complete();
    }
}
